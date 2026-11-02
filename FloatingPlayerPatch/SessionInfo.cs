using SteamworksNative;
using System;
using UnhollowerBaseLib;

namespace FloatingPlayerPatch
{
    internal static unsafe class SessionInfo
    {
        private static readonly SteamNetworkingIdentity _identity = new();
        private static readonly SteamNetConnectionInfo_t _info = new();
        private static readonly SteamNetworkingQuickConnectionStatus _status = new();

        internal static ESteamNetworkingConnectionState GetState(ulong steamId)
        {
            _identity.SetSteamID64(steamId);

            IntPtr* args = stackalloc IntPtr[3];
            args[0] = IL2CPP.il2cpp_object_unbox(_identity.Pointer);
            args[1] = IL2CPP.il2cpp_object_unbox(_info.Pointer);
            args[2] = IL2CPP.il2cpp_object_unbox(_status.Pointer);

            IntPtr exception = IntPtr.Zero;
            IntPtr result = IL2CPP.il2cpp_runtime_invoke(
                SteamNetworkingMessages.NativeMethodInfoPtr_GetSessionConnectionInfo_Public_Static_ESteamNetworkingConnectionState_byref_SteamNetworkingIdentity_byref_SteamNetConnectionInfo_t_byref_SteamNetworkingQuickConnectionStatus_0,
                IntPtr.Zero, (void**)args, ref exception
            );
            Il2CppException.RaiseExceptionIfNecessary(exception);

            return *(ESteamNetworkingConnectionState*)IL2CPP.il2cpp_object_unbox(result);
        }
    }
}