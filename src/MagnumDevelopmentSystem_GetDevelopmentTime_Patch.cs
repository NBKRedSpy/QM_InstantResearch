using HarmonyLib;
using MGSC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace QM_InstantResearch
{
    [HarmonyPatch(typeof(MagnumDevelopmentSystem), nameof(MagnumDevelopmentSystem.GetDevelopmentTime))]
    public static class MagnumDevelopmentSystem_GetDevelopmentTime_Patch
    {
        public static void Postfix(ref int __result)
        {
            __result = 0;
        }
    }
}
