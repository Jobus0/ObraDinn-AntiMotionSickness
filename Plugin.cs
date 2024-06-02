using BepInEx;
using HarmonyLib;
using System.Reflection;
using BepInEx.Configuration;

namespace AntiMotionSickness
{
    [BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        public static ConfigEntry<float> ConfigFov;
        public static ConfigEntry<bool> ConfigDisableShipSway;
        public static ConfigEntry<bool> ConfigDisableFringeDistortion;
        public static ConfigEntry<bool> ConfigDisableEdgeBlur;
        public static ConfigEntry<bool> ConfigDisableHeadBob;
        
        private void Awake()
        {
            ConfigFov = Config.Bind("General", "FOV", 70f, "The first-person field of view (vanilla: 58).");
            ConfigDisableShipSway = Config.Bind("General", "DisableShipSway", true, "Disables the swaying of the ship.");
            ConfigDisableFringeDistortion = Config.Bind("General", "DisableFringeDistortion", true, "Disables the wavy pattern on the edges of the screen during memories.");
            ConfigDisableEdgeBlur = Config.Bind("General", "DisableEdgeBlur", true, "Disables the blur effect on the edges of the screen. (Only during Smooth output mode)");
            ConfigDisableHeadBob = Config.Bind("General", "DisableHeadBob", true, "Disables the head bobbing when the player is walking.");
            
            // Plugin startup logic
            Logger.LogInfo($"   Plugin {MyPluginInfo.PLUGIN_GUID} is loaded!");

            Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly());
        }
    }
}