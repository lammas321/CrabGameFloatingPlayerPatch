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

            if (Config.Bind("FloatingPlayerPatch", "OnlyEstablishConnectionWithHostAsClient", false,
                "This will make you only establish a connection with the host, if that host is sharing that they have FloatingPlayerPatch via ModList. This may allow you to join the game a bit faster (as you won't have to establish a bunch of pointless connections) and will make you not send any packets to any other players besides the host, saving some bandwidth. This will also only make you accept player position and rotation packets from the host, meaning that no one can lie to you about their positon.").Value)
                harmony.PatchAll(typeof(OnlyConnectToHostPatches));

            Log.LogInfo($"Initialized [{MyPluginInfo.PLUGIN_NAME} {MyPluginInfo.PLUGIN_VERSION}]");
        }
    }
}