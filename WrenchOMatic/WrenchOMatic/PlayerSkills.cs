using Il2Cpp;
using UnityEngine;
using HarmonyLib;
using MelonLoader;

namespace WrenchOMatic
{
    //[HarmonyPatch(typeof(MountObject), nameof(MountObject.Update))]
    public class PlayerSkills : MonoBehaviour
    {
        public static void MultiplyScrewSpeed()
        {
            Cursor3D cursor = Cursor3D.Get();
            if (cursor.isHoldInProgress)
            {
                MelonLogger.Msg(cursor.name);
                MelonLogger.Msg(cursor.holdID);
                //cursor.holdTime *= Configurator._wrenchOSettings.Value.ScrewSpeedMultiplier;
            }
        }
        public static bool MultiplyExperienceGained(ref int exp, ref bool instant)
        {
            exp *= Configurator._wrenchOSettings.Value.ExperienceGainedMultiplier;
            instant = true;
            return true;
        }
        public static bool MultiplyMoneyGained(ref int money)
        {
            if(money > 0)
            {
                money *= Configurator._wrenchOSettings.Value.MoneyGainedMultiplier;
            }
            return true;
        }

    }
}
