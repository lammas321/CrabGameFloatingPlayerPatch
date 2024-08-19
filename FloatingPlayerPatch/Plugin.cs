using BepInEx;
using BepInEx.IL2CPP;
using HarmonyLib;

namespace FloatingPlayerPatch
{
    [BepInPlugin($"lammas123.{MyPluginInfo.PLUGIN_NAME}", MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
    [BepInDependency("lammas123.ModList", BepInDependency.DependencyFlags.SoftDependency)]
    public class FloatingPlayerPatch : BasePlugin
    {
        public override void Load()
        {
            if (ModListCompatibility.Enabled)
                ModListCompatibility.AddMod($"lammas123.{MyPluginInfo.PLUGIN_NAME}");
            
            Harmony.CreateAndPatchAll(typeof(Patches));
            Log.LogInfo($"Loaded [{MyPluginInfo.PLUGIN_NAME} {MyPluginInfo.PLUGIN_VERSION}]");
        }
    }
}