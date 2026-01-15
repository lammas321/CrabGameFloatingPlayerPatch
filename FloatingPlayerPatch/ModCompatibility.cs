using BepInEx.IL2CPP;
using System.Runtime.CompilerServices;

namespace FloatingPlayerPatch
{
    internal static class ModListCompatibility
    {
        internal const string GUID = "lammas123.ModList";

        internal static bool? enabled;
        internal static bool Enabled { get => enabled == null ? (bool)(enabled = IL2CPPChainloader.Instance.Plugins.ContainsKey(GUID)) : enabled.Value; }

        [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
        internal static void AddMod(string guid, bool required = false)
            => ModList.Api.AddMod(guid, required);
    }
}