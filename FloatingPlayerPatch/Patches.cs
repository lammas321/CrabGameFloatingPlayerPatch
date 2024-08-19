using HarmonyLib;
using System;

namespace FloatingPlayerPatch
{
    internal static class Patches
    {
        //   Anti Bepinex detection (Thanks o7Moon: https://github.com/o7Moon/CrabGame.AntiAntiBepinex)
        [HarmonyPatch(typeof(EffectManager), nameof(EffectManager.Method_Private_Void_GameObject_Boolean_Vector3_Quaternion_0))] // Ensures effectSeed is never set to 4200069 (if it is, modding has been detected)
        [HarmonyPatch(typeof(LobbyManager), nameof(LobbyManager.Method_Private_Void_0))] // Ensures connectedToSteam stays false (true means modding has been detected)
        // [HarmonyPatch(typeof(SnowSpeedModdingDetector), nameof(SnowSpeedModdingDetector.Method_Private_Void_0))] // Would ensure snowSpeed is never set to Vector3.zero (though it is immediately set back to Vector3.one due to an accident on Dani's part lol)
        [HarmonyPrefix]
        public static bool PreBepinexDetection()
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
        // far away, but others without the mod that are nearby will still appear laggy to you.
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
    }
}