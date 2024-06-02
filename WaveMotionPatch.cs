using HarmonyLib;

namespace AntiMotionSickness
{
    [HarmonyPatch]
    internal class WaveMotionPatch
    {
        [HarmonyPatch(typeof(WaveMotion), "Update")]
        [HarmonyPrefix]
        public static bool Prefix_OnEnable(WaveMotion __instance, ref bool ___isOn)
        {
            if (Plugin.ConfigDisableShipSway.Value)
            {
                ___isOn = false;
                return false;
            }
            
            return true;
        }
    }
}