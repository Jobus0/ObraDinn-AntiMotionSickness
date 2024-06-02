using HarmonyLib;

namespace AntiMotionSickness
{
    [HarmonyPatch]
    internal class MonitorPatch
    {
        [HarmonyPostfix]
        [HarmonyPatch(typeof(Monitor), "OnEnable")]
        public static void Postfix_OnEnable(Monitor __instance)
        {
            if (Plugin.ConfigDisableEdgeBlur.Value)
                __instance.blurAtEdges = false;
        }
    }
}
