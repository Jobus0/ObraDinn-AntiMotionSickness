using System;
using BepInEx.Configuration;
using HarmonyLib;
using UnityEngine;

namespace AntiMotionSickness
{
    [HarmonyPatch]
    internal class ZoomerPatch
    {
        [HarmonyPostfix]
        [HarmonyPatch(typeof(Zoomer), "Start")]
        public static void Postfix_Start(ref float ___fovDefault)
        {
            ___fovDefault = Plugin.ConfigFov.Value;
        }
    }
}