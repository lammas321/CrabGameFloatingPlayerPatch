using BepInEx.IL2CPP.Utils;
using HarmonyLib;
using SteamworksNative;
using System;
using System.Collections;
using TMPro;
using UnityEngine;

namespace FloatingPlayerPatch
{
    internal static class Patches
    {
        //   Anti BepInEx detection (Thanks o7Moon: https://github.com/o7Moon/CrabGame.AntiAntiBepinex)
        [HarmonyPatch(typeof(EffectManager), nameof(EffectManager.Method_Private_Void_GameObject_Boolean_Vector3_Quaternion_0))] // Ensures effectSeed is never set to 4200069 (if it is, modding has been detected)
        [HarmonyPatch(typeof(LobbyManager), nameof(LobbyManager.Method_Private_Void_0))] // Ensures connectedToSteam stays false (true means modding has been detected)
        // [HarmonyPatch(typeof(Deobf_MenuSnowSpeedModdingDetector), nameof(Deobf_MenuSnowSpeedModdingDetector.Method_Private_Void_0))] // Would ensure snowSpeed is never set to Vector3.zero (though it is immediately set back to Vector3.one due to an accident on Dani's part lol)
        [HarmonyPrefix]
        internal static bool PreBepinexDetection()
            => false;


        //   Server Side Floating Player Patch
        // Broadcasts all received player positions to all other players, fixing the issue
        // where some players will appear to float for others, but never you as the host.

        //   Client Side Ignore Client Position Updates Patch
        // If the host has FloatingPlayerPatch, ignore position and rotation updates from
        // clients, preventing the movement jitter of other players from receiving the same
        // position updates from both the host and said players at different, offset times.
        [HarmonyPatch(typeof(ServerHandle), nameof(ServerHandle.PlayerPosition))]
        [HarmonyPrefix]
        [HarmonyPriority(Priority.Low)]
        internal static bool PreServerHandlePlayerPosition(ulong param_0, Packet param_1)
        {
            if (SteamManager.Instance.IsLobbyOwner())
            {
                ServerSend.PlayerPosition(param_0, new(BitConverter.ToSingle(param_1.field_Private_ArrayOf_Byte_0, 8), BitConverter.ToSingle(param_1.field_Private_ArrayOf_Byte_0, 12), BitConverter.ToSingle(param_1.field_Private_ArrayOf_Byte_0, 16)));
                return true;
            }

            return !FloatingPlayerPatch.Instance.lobbyHasFloatingPlayerPatch || param_0 == SteamManager.Instance.field_Private_CSteamID_1.m_SteamID;
        }

        [HarmonyPatch(typeof(ServerHandle), nameof(ServerHandle.PlayerRotation))]
        [HarmonyPrefix]
        [HarmonyPriority(Priority.Low)]
        internal static bool PreServerHandlePlayerRotation(ulong param_0, Packet param_1)
        {
            if (SteamManager.Instance.IsLobbyOwner())
            {
                ServerSend.PlayerRotation(param_0, BitConverter.ToSingle(param_1.field_Private_ArrayOf_Byte_0, 8), BitConverter.ToSingle(param_1.field_Private_ArrayOf_Byte_0, 12));
                return true;
            }

            return !FloatingPlayerPatch.Instance.lobbyHasFloatingPlayerPatch || param_0 == SteamManager.Instance.field_Private_CSteamID_1.m_SteamID;
        }


        //   Client Side Laggy Movement Patch
        // This will make you treat the host as if they're always nearby, meaning that you'll
        // send them the same frequency of position and rotation updates, regardless of how far
        // away you are. This way, you won't appear as laggy to nearby players if the host is
        // far away. Others without the mod that are nearby will still appear laggy to you.
        [HarmonyPatch(typeof(PlayerServerCommunication), nameof(PlayerServerCommunication.Method_Private_Void_Vector3_EnumNPublicSealedvaClMeFaAn5vUnique_0))]
        [HarmonyPrefix]
        internal static void PrePlayerCommunicationUpdatePosition(PlayerServerCommunication __instance)
        {
            if (!SteamManager.Instance.IsLobbyOwner() && FloatingPlayerPatch.Instance.lobbyHasFloatingPlayerPatch)
                __instance.idToDistance[SteamManager.Instance.field_Private_CSteamID_1.m_SteamID] = PlayerServerCommunication_RenderDistance.Close;
        }

        [HarmonyPatch(typeof(PlayerServerCommunication), nameof(PlayerServerCommunication.Method_Private_Void_Single_Single_EnumNPublicSealedvaClMeFaAn5vUnique_0))]
        [HarmonyPrefix]
        internal static void PrePlayerCommunicationUpdateRotation(PlayerServerCommunication __instance)
        {
            if (!SteamManager.Instance.IsLobbyOwner() && FloatingPlayerPatch.Instance.lobbyHasFloatingPlayerPatch)
                __instance.idToDistance[SteamManager.Instance.field_Private_CSteamID_1.m_SteamID] = PlayerServerCommunication_RenderDistance.Close;
        }


        //   Client Side Host Priority Patch
        // Prioritize establishing a connection with the host before other clients. This
        // should make the connection with the host establish faster and get you in the game
        // sooner. If the host has FloatingPlayerPatch, you will skip establishing connections
        // with other players, as you won't need their connections anyways.
        [HarmonyPatch(typeof(SteamManager), nameof(SteamManager.OnEnable))]
        [HarmonyPrefix]
        internal static bool PreSteamManagerOnEnable(SteamManager __instance)
        {
            if (__instance == SteamManager.Instance)
            {
                SteamManager.Instance.StartCoroutine(CoroCheckHostConnection());
                SteamManager.Instance.StartCoroutine(CoroTryEstablishHostConnection());
                SteamManager.Instance.StartCoroutine(CoroTryEstablishConnections());
            }

            return false;
        }

        internal static float hostConnectionStartTime = 0f;
        internal static IEnumerator CoroCheckHostConnection()
        {
            while (true)
            {
                yield return new WaitForSeconds(0.1f);

                if (SteamManager.Instance.currentLobby.m_SteamID == 0ul || SteamManager.Instance.field_Private_CSteamID_1.m_SteamID == 0ul || !FloatingPlayerPatch.Instance.establishingHostConnection || !MenuUI.Instance)
                    continue;

                ESteamNetworkingConnectionState state = SessionInfo.GetState(SteamManager.Instance.field_Private_CSteamID_1.m_SteamID);

                string prefix = "k_ESteamNetworkingConnectionState_";
                string stateName = state.ToString();
                if (stateName.StartsWith(prefix))
                    stateName = stateName[prefix.Length..];

                try
                {
                    MenuUI.Instance.lobbyUi.transform.GetChild(1).GetChild(0).GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().text =
                        $"Joining server, please wait...<size=75%>\nHost Connection State: {stateName}\nElapsed: {Time.realtimeSinceStartup - hostConnectionStartTime:0.0}s";
                }
                catch { }
            }
        }

        internal static IEnumerator CoroTryEstablishHostConnection()
        {
            while (true)
            {
                yield return new WaitForSeconds(3f);

                if (SteamManager.Instance.currentLobby.m_SteamID == 0ul || SteamManager.Instance.field_Private_CSteamID_1.m_SteamID == 0ul || !FloatingPlayerPatch.Instance.establishingHostConnection)
                    continue;

                ClientSend.LoadMapRequest();

                ESteamNetworkingConnectionState state = SessionInfo.GetState(SteamManager.Instance.field_Private_CSteamID_1.m_SteamID);
                if (state != ESteamNetworkingConnectionState.k_ESteamNetworkingConnectionState_Connected &&
                    state != ESteamNetworkingConnectionState.k_ESteamNetworkingConnectionState_Connecting &&
                    state != ESteamNetworkingConnectionState.k_ESteamNetworkingConnectionState_FindingRoute)
                {
                    SteamManager.Instance.StopP2P(SteamManager.Instance.field_Private_CSteamID_1);
                    SteamManager.Instance.NewAcceptP2P(SteamManager.Instance.field_Private_CSteamID_1);
                    ClientSend.HandShake(SteamManager.Instance.field_Private_CSteamID_1.m_SteamID);
                }
            }
        }

        internal static IEnumerator CoroTryEstablishConnections()
        {
            while (true)
            {
                yield return new WaitForSeconds(10f);

                if (SteamManager.Instance.currentLobby.m_SteamID == 0ul || SteamManager.Instance.field_Private_CSteamID_1.m_SteamID == 0ul || FloatingPlayerPatch.Instance.establishingHostConnection)
                    continue;

                SteamManager.Instance.Method_Private_Void_PDM_1();
            }
        }


        // Tells clients with the mod that you have FloatingPlayerPatch as the host.
        // Marks when we're establishing a connection with the lobby host.
        [HarmonyPatch(typeof(SteamManager), nameof(SteamManager.Method_Private_Void_LobbyEnter_t_PDM_1))]
        [HarmonyPrefix]
        internal static void PreSteamManagerLobbyEnter(LobbyEnter_t param_1)
        {
            CSteamID lobbyId = new(param_1.m_ulSteamIDLobby);
            if (SteamMatchmaking.GetLobbyOwner(lobbyId).m_SteamID == SteamManager.Instance.field_Private_CSteamID_0.m_SteamID)
            {
                SteamMatchmaking.SetLobbyData(lobbyId, MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_VERSION);

                FloatingPlayerPatch.Instance.establishingHostConnection = false;

                hostConnectionStartTime = 0f;
                return;
            }

            FloatingPlayerPatch.Instance.lobbyHasFloatingPlayerPatch = !string.IsNullOrEmpty(SteamMatchmaking.GetLobbyData(lobbyId, MyPluginInfo.PLUGIN_GUID));

            FloatingPlayerPatch.Instance.establishingHostConnection = true;

            if (hostConnectionStartTime == 0f)
                hostConnectionStartTime = Time.realtimeSinceStartup;
        }

        [HarmonyPatch(typeof(SteamManager), nameof(SteamManager.JoinLobby))]
        [HarmonyPrefix]
        internal static void PreSteamManagerJoinLobby(CSteamID param_1)
        {
            if (param_1 != SteamManager.Instance.currentLobby)
            {
                FloatingPlayerPatch.Instance.establishingHostConnection = true;

                hostConnectionStartTime = Time.realtimeSinceStartup;
            }
        }

        [HarmonyPatch(typeof(ClientHandle), nameof(ClientHandle.LoadMap))]
        [HarmonyPostfix]
        internal static void PostClientHandleLoadMap()
        {
            FloatingPlayerPatch.Instance.establishingHostConnection = false;

            hostConnectionStartTime = 0f;
        }

        [HarmonyPatch(typeof(SteamManager), nameof(SteamManager.LeaveLobby))]
        [HarmonyPostfix]
        internal static void PostSteamManagerLeaveLobby()
        {
            FloatingPlayerPatch.Instance.lobbyHasFloatingPlayerPatch = false;

            FloatingPlayerPatch.Instance.establishingHostConnection = false;

            hostConnectionStartTime = 0f;
        }
        

        // Allows or denies connections under the following conditions:
        internal static bool ShouldConnect(ulong clientId)
        {
            // We're not in a lobby yet.
            if (SteamManager.Instance.currentLobby.m_SteamID == 0ul)
                return false;

            // Who are we trying to connect to?
            if (clientId <= 1ul)
                return false;

            // We are the host, or clientId is the host.
            if (SteamManager.Instance.IsLobbyOwner() || clientId == SteamManager.Instance.field_Private_CSteamID_1.m_SteamID)
                return true;

            // Already establish a connection with the host, establish connections with others if FloatingPlayerPatch is not present.
            if (!FloatingPlayerPatch.Instance.establishingHostConnection)
                return !FloatingPlayerPatch.Instance.lobbyHasFloatingPlayerPatch;

            return false;
        }

        [HarmonyPatch(typeof(SteamManager), nameof(SteamManager.NewAcceptP2P), [typeof(CSteamID)])]
        [HarmonyPrefix]
        internal static bool PreSteamManagerNewAcceptP2P(CSteamID param_1)
            => ShouldConnect(param_1.m_SteamID);

        [HarmonyPatch(typeof(SteamManager), nameof(SteamManager.NewAcceptP2P), [typeof(SteamNetworkingIdentity)])]
        [HarmonyPrefix]
        internal static bool PreSteamManagerNewAcceptP2P(SteamNetworkingIdentity param_1)
            => ShouldConnect(param_1.GetSteamID64());

        [HarmonyPatch(typeof(SteamPacketManager), nameof(SteamPacketManager.SendPacket))]
        [HarmonyPrefix]
        internal static bool PreSteamPacketManagerSendPacket(CSteamID param_0)
            => ShouldConnect(param_0.m_SteamID);

        [HarmonyPatch(typeof(_Dissonance_Integrations_SteamworksP2P__SteamworksP2PCommsNetwork), nameof(_Dissonance_Integrations_SteamworksP2P__SteamworksP2PCommsNetwork.Method_Internal_Boolean_CSteamID_ArraySegment_1_Byte_EP2PSend_Boolean_1))]
        [HarmonyPrefix]
        internal static bool Pre_Dissonance_Integrations_SteamworksP2P__SteamworksP2PCommsNetworkSend(CSteamID param_1)
            => ShouldConnect(param_1.m_SteamID);


        // Debug logging
        /*[HarmonyPatch(typeof(SteamManager), nameof(SteamManager.Start))]
        [HarmonyPostfix]
        internal static void PostSteamManagerStart()
        {
            SteamNetworkingDebugLog.Enable();
        }*/
    }
}