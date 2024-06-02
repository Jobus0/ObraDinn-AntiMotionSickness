using HarmonyLib;

namespace AntiMotionSickness
{
    [HarmonyPatch]
    internal class HeadMotionPatch
    {
        [HarmonyPatch(typeof(HeadMotion), "SetOffset")]
        [HarmonyPrefix]
        public static bool Prefix_SetOffset(HeadMotion.Id id)
        {
            if (Plugin.ConfigDisableHeadBob.Value)
                return id != HeadMotion.Id.FromWalk;
            
            return true;
        }
    }
}