using HarmonyLib;
using Il2Cpp;
using Il2CppCMS.UI.Logic.Scrap;
using MelonLoader;
using System.Linq.Expressions;
using UnityEngine;

[assembly: MelonInfo(typeof(WrenchOMatic.Wrencher), "WrenchOMatic", "1.0.0", "Tyler", null)]
[assembly: MelonGame("Red Dot Games", "Car Mechanic Simulator 2021")]

namespace WrenchOMatic
{
    public class Wrencher : MelonMod
    {
        public override void OnInitializeMelon()
        {
            LoggerInstance.Msg("Initialized WrenchOMatic");
            try
            {

                Configurator melonConfig = new();
                HarmonyLib.Harmony harmony = new("RSG.Moss.WrenchOMatic");
                PatchScrap(ref harmony);
                PatchPlayerSkills(ref harmony);
            }
            catch (Exception ex)
            {
                MelonLogger.Msg("Harmony - FAILED to Apply Patch's!");
                MelonLogger.Msg(ex.Message);
            }
        }
        private static bool PatchScrap(ref HarmonyLib.Harmony harREf )
        {
            try
            {
                MelonLogger.Msg("Harmony - Patching ScrapProduction MakeScrap...");

                harREf.Patch(AccessTools.Method(typeof(ScrapProduction), "MakeScrap"), new HarmonyMethod(typeof(Scrapper), "MakeScrap"));
                MelonLogger.Msg("Harmony - Patched ScrapProduction MakeScrap!");

                MelonLogger.Msg("Harmony - Patching ScrapProduction ProcessGameResult...");
                harREf.Patch(AccessTools.Method(typeof(ScrapProduction), "ProcessGameResult"), new HarmonyMethod(typeof(Scrapper), "ProcessGameResult"));
                MelonLogger.Msg("Harmony - Patched ScrapProduction ProcessGameResult!");
                return true;
            } catch (Exception ex) 
            {
                MelonLogger.Msg("Harmony - FAILED to Apply Scrap Patch's!");
                MelonLogger.Msg(ex.Message);
                return false;
                }
        }
        private static bool PatchPlayerSkills(ref HarmonyLib.Harmony harREf)
        {
            try
            {
                MelonLogger.Msg("Harmony - Patching Screw Speed Update Method...");

                harREf.Patch(AccessTools.Method(typeof(Cursor3D), "Update"), new HarmonyMethod(typeof(PlayerSkills), nameof(PlayerSkills.MultiplyScrewSpeed)));
                MelonLogger.Msg("Harmony - Patched Screw Speed!");

                MelonLogger.Msg("Harmony - Patching Experience Gained Method...");

                harREf.Patch(AccessTools.Method(typeof(GlobalData), "AddPlayerExp"), new HarmonyMethod(typeof(PlayerSkills), nameof(PlayerSkills.MultiplyExperienceGained)));
                MelonLogger.Msg("Harmony - Patched Experience Gained!");

                MelonLogger.Msg("Harmony - Patching Money Gained Method...");

                harREf.Patch(AccessTools.Method(typeof(GlobalData), "AddPlayerMoney"), new HarmonyMethod(typeof(PlayerSkills), nameof(PlayerSkills.MultiplyMoneyGained)));
                MelonLogger.Msg("Harmony - Patched Money Gained!");
                return true;
        } catch (Exception ex)
            {
                MelonLogger.Msg("Harmony - FAILED to Apply Scrap Patch's!");
                MelonLogger.Msg(ex.Message);
                return false;
                }
}

    }
}