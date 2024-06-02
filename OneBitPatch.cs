using HarmonyLib;

namespace AntiMotionSickness
{
    [HarmonyPatch]
    internal class OneBitPatch
    {
        [HarmonyPostfix]
        [HarmonyPatch(typeof(OneBit), "OnEnable")]
        public static void Postfix_OnEnable(OneBit __instance)
        {
            if (Plugin.ConfigDisableFringeDistortion.Value)
                __instance.linedSettings.distortFringe = false;
        }
    }
}