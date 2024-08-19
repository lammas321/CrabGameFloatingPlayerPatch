using BepInEx.IL2CPP;
using System.Runtime.CompilerServices;

namespace FloatingPlayerPatch
{
    public static class ModListCompatibility
    {
        internal static bool? enabled;
        public static bool Enabled { get => enabled == null ? (bool)(enabled = IL2CPPChainloader.Instance.Plugins.ContainsKey("lammas123.ModList")) : enabled.Value; }

        [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
        public static void AddMod(string guid)
            => ModList.Api.AddMod(guid);

        [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
        public static void IsModShared(string guid)
            => ModList.Api.IsModShared(guid);

        [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
        public static void IsModRequired(string guid)
            => ModList.Api.IsModRequired(guid);
    }
}