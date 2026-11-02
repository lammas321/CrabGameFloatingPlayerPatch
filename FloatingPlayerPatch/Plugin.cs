using BepInEx;
using BepInEx.IL2CPP;
using HarmonyLib;
using System.Globalization;

namespace FloatingPlayerPatch
{
    [BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
    [BepInDependency(ModListCompatibility.GUID, BepInDependency.DependencyFlags.SoftDependency)]
    public sealed class FloatingPlayerPatch : BasePlugin
    {
        internal static FloatingPlayerPatch Instance { get; private set; }
        
        internal bool lobbyHasFloatingPlayerPatch = false;

        internal bool establishingHostConnection = false;
        

        public override void Load()
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.InvariantCulture;

            Instance = this;

            if (ModListCompatibility.Enabled)
                ModListCompatibility.AddMod(MyPluginInfo.PLUGIN_GUID, required: false);
            
            Harmony harmony = new(MyPluginInfo.PLUGIN_NAME);
            harmony.PatchAll(typeof(Patches));

            Log.LogInfo($"Initialized [{MyPluginInfo.PLUGIN_NAME} {MyPluginInfo.PLUGIN_VERSION}]");
        }
    }
}