using BepInEx;
using BepInEx.IL2CPP;
using HarmonyLib;

namespace FloatingPlayerPatch
{
    [BepInPlugin("lammas123.FloatingPlayerPatch", "FloatingPlayerPatch", MyPluginInfo.PLUGIN_VERSION)]
    public class FloatingPlayerPatch : BasePlugin
    {
        public override void Load()
        {
            Harmony.CreateAndPatchAll(typeof(Patches));
            Log.LogInfo($"Loaded [{MyPluginInfo.PLUGIN_NAME} {MyPluginInfo.PLUGIN_VERSION}]");
        }
    }
}