using BepInEx.IL2CPP;
using System.Runtime.CompilerServices;

namespace FloatingPlayerPatch
{
    internal static class ModListCompatibility
    {
        internal static bool? enabled;
        internal static bool Enabled { get => enabled == null ? (bool)(enabled = IL2CPPChainloader.Instance.Plugins.ContainsKey("lammas123.ModList")) : enabled.Value; }

        [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
        internal static void AddMod(string guid)
            => ModList.Api.AddMod(guid);
    }
}