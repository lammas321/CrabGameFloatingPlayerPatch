using HarmonyLib;
using System;

namespace FloatingPlayerPatch
{
    internal static class Patches
    {
        // Anti Bepinex detection (thanks o7Moon https://github.com/o7Moon/CrabGame.AntiAntiBepinex)
        [HarmonyPatch(typeof(EffectManager), nameof(EffectManager.Method_Private_Void_GameObject_Boolean_Vector3_Quaternion_0))] // Ensures effectSeed is never set to 4200069 (if it is, modding has been detected)
        [HarmonyPatch(typeof(LobbyManager), nameof(LobbyManager.Method_Private_Void_0))] // Ensures connectedToSteam stays false (true means modding has been detected)
        //[HarmonyPatch(typeof(SnowSpeedModdingDetector), nameof(SnowSpeedModdingDetector.Method_Private_Void_0))] // Would ensure snowSpeed is never set to Vector3.zero, but it is immediately set back to Vector3.one due to an accident on Dani's part lol
        [HarmonyPrefix]
        public static bool PreBepinexDetection() => false;

        // Floating player patch
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
    }
}