using BepInEx.IL2CPP.Utils;
using HarmonyLib;
using SteamworksNative;
using System;
using System.Collections;
using UnityEngine;

namespace FloatingPlayerPatch
{
    internal static class Patches
    {
        //   Anti Bepinex detection (Thanks o7Moon: https://github.com/o7Moon/CrabGame.AntiAntiBepinex)
        [HarmonyPatch(typeof(EffectManager), nameof(EffectManager.Method_Private_Void_GameObject_Boolean_Vector3_Quaternion_0))] // Ensures effectSeed is never set to 4200069 (if it is, modding has been detected)
        [HarmonyPatch(typeof(LobbyManager), nameof(LobbyManager.Method_Private_Void_0))] // Ensures connectedToSteam stays false (true means modding has been detected)
        // [HarmonyPatch(typeof(SnowSpeedModdingDetector), nameof(SnowSpeedModdingDetector.Method_Private_Void_0))] // Would ensure snowSpeed is never set to Vector3.zero (though it is immediately set back to Vector3.one due to an accident on Dani's part lol)
        [HarmonyPrefix]
        internal static bool PreBepinexDetection()
            => false;


        //   Server Side Floating Player Patch
        // Broadcasts all received player positions to all other players, fixing the issue
        // where some players will appear to float for others, but never you as the host.
        [HarmonyPatch(typeof(ServerHandle), nameof(ServerHandle.PlayerPosition))]
        [HarmonyPostfix]
        internal static void PostServerHandlePlayerPosition(ulong param_0, Packet param_1)
        {
            if (SteamManager.Instance.IsLobbyOwner())
                ServerSend.PlayerPosition(param_0, new(BitConverter.ToSingle(param_1.field_Private_ArrayOf_Byte_0, 8), BitConverter.ToSingle(param_1.field_Private_ArrayOf_Byte_0, 12), BitConverter.ToSingle(param_1.field_Private_ArrayOf_Byte_0, 16)));
        }
        [HarmonyPatch(typeof(ServerHandle), nameof(ServerHandle.PlayerRotation))]
        [HarmonyPostfix]
        internal static void PostServerHandlePlayerRotation(ulong param_0, Packet param_1)
        {
            if (SteamManager.Instance.IsLobbyOwner())
                ServerSend.PlayerRotation(param_0, BitConverter.ToSingle(param_1.field_Private_ArrayOf_Byte_0, 8), BitConverter.ToSingle(param_1.field_Private_ArrayOf_Byte_0, 12));
        }


        //   Client Side Laggy Movement Patch
        // This will make you treat the host as if they're always nearby, meaning that you'll
        // send them the same frequency of position and rotation updates, regardless of how far
        // away you are. This way, you won't appear as laggy to nearby players if the host is
        // far away. Others without the mod that are nearby will still appear laggy to you.
        [HarmonyPatch(typeof(PlayerCommunication), nameof(PlayerCommunication.Method_Private_Void_Vector3_EnumNPublicSealedvaClMeFaAn5vUnique_0))]
        [HarmonyPrefix]
        internal static void PrePlayerCommunicationUpdatePosition(PlayerCommunication __instance)
        {
            if (!SteamManager.Instance.IsLobbyOwner())
                __instance.idToDistance[SteamManager.Instance.field_Private_CSteamID_1.m_SteamID] = PlayerCommunicationDistance.Close;
        }
        [HarmonyPatch(typeof(PlayerCommunication), nameof(PlayerCommunication.Method_Private_Void_Single_Single_EnumNPublicSealedvaClMeFaAn5vUnique_0))]
        [HarmonyPrefix]
        internal static void PrePlayerCommunicationUpdateRotation(PlayerCommunication __instance)
        {
            if (!SteamManager.Instance.IsLobbyOwner())
                __instance.idToDistance[SteamManager.Instance.field_Private_CSteamID_1.m_SteamID] = PlayerCommunicationDistance.Close;
        }


        //   Tells clients with the mod that you have FloatingPlayerPatch as the host
        [HarmonyPatch(typeof(LobbyManager), nameof(LobbyManager.StartLobby))]
        [HarmonyPatch(typeof(LobbyManager), nameof(LobbyManager.StartPracticeLobby))]
        [HarmonyPostfix]
        internal static void PostLobbyManagerStartLobby()
            => SteamMatchmaking.SetLobbyData(SteamManager.Instance.currentLobby, $"lammas123.{MyPluginInfo.PLUGIN_GUID}", "1");
    }

    internal static class OnlyConnectToHostPatches
    {
        //   Only Establish Connection with Host as Client
        // This will make you only establish a connection with the host.
        // This may allow you to join the game a bit faster (as you won't
        // have to establish a bunch of pointless connections) and will
        // make you not send any packets to any other players besides
        // the host, saving some bandwidth. This will also only make
        // you accept player position and rotation packets from the
        // host, meaning that no one can lie to you about their positon.
        internal static IEnumerator TryEnterGame()
        {
            while (true)
            {
                yield return new WaitForSeconds(1f);
                SteamManager.Instance.Method_Private_Void_PDM_1();

                if (!GameManager.Instance || ShouldSend(SteamManager.Instance.field_Private_CSteamID_0.m_SteamID))
                    continue;

                foreach (ulong clientId in GameManager.Instance.activePlayers.Keys)
                    if (clientId != SteamManager.Instance.field_Private_CSteamID_1.m_SteamID)
                        SteamManager.Instance.StopP2P(new(clientId));
                foreach (ulong clientId in GameManager.Instance.spectators.Keys)
                    if (clientId != SteamManager.Instance.field_Private_CSteamID_1.m_SteamID)
                        SteamManager.Instance.StopP2P(new(clientId));
            }
        }
        internal static bool ShouldSend(ulong clientId)
            => SteamManager.Instance.IsLobbyOwner() || SteamMatchmaking.GetLobbyData(SteamManager.Instance.currentLobby, $"lammas123.{MyPluginInfo.PLUGIN_GUID}") != "1" || clientId == SteamManager.Instance.field_Private_CSteamID_1.m_SteamID;

        [HarmonyPatch(typeof(SteamManager), nameof(SteamManager.OnEnable))]
        [HarmonyPrefix]
        internal static bool PreSteamManagerOnEnable()
        {
            SteamManager.Instance.StartCoroutine(TryEnterGame());
            return false;
        }

        [HarmonyPatch(typeof(SteamManager), nameof(SteamManager.NewAcceptP2P), [typeof(CSteamID)])]
        [HarmonyPrefix]
        internal static bool PreSteamManagerNewAcceptP2P(CSteamID param_1)
            => ShouldSend(param_1.m_SteamID);
        [HarmonyPatch(typeof(SteamManager), nameof(SteamManager.NewAcceptP2P), [typeof(SteamNetworkingIdentity)])]
        [HarmonyPrefix]
        internal static bool PreSteamManagerNewAcceptP2P(SteamNetworkingIdentity param_1)
            => ShouldSend(param_1.GetSteamID64());

        [HarmonyPatch(typeof(ClientSend), nameof(ClientSend.HandShake))]
        [HarmonyPrefix]
        internal static bool PreClientSendHandShake(ulong param_0)
            => ShouldSend(param_0);
        [HarmonyPatch(typeof(ClientSend), nameof(ClientSend.PlayerPosition))]
        [HarmonyPrefix]
        internal static bool PreClientSendPlayerPosition(ulong param_1)
            => ShouldSend(param_1);
        [HarmonyPatch(typeof(ClientSend), nameof(ClientSend.PlayerRotation))]
        [HarmonyPrefix]
        internal static bool PreClientSendPlayerRotation(ulong param_2)
            => ShouldSend(param_2);
    }
}