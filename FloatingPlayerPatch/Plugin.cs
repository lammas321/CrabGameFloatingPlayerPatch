using BepInEx;
using BepInEx.IL2CPP;
using HarmonyLib;
using ModList;

namespace FloatingPlayerPatch
{
    [BepInPlugin($"lammas123.{MyPluginInfo.PLUGIN_NAME}", MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
    [BepInDependency("lammas123.ModList", BepInDependency.DependencyFlags.SoftDependency)]
    public class FloatingPlayerPatch : BasePlugin
    {
        public override void Load()
        {
            if (IL2CPPChainloader.Instance.Plugins.ContainsKey("lammas123.ModList"))
                ModList.ModList.AddMod($"lammas123.{MyPluginInfo.PLUGIN_NAME}");
            
            Harmony.CreateAndPatchAll(typeof(Patches));
            Log.LogInfo($"Loaded [{MyPluginInfo.PLUGIN_NAME} {MyPluginInfo.PLUGIN_VERSION}]");
        }
    }
}