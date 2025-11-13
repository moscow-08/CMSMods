using HarmonyLib;
using Il2Cpp;
using Il2CppCMS.UI.Logic.Scrap;
using MelonLoader;
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
                MelonLogger.Msg("Harmony - Patching ScrapProduction MakeScrap...");
                harmony.Patch(AccessTools.Method(typeof(ScrapProduction), "MakeScrap"), new HarmonyMethod(typeof(Scrapper), "MakeScrap"));
                MelonLogger.Msg("Harmony - Patched ScrapProduction MakeScrap!");
                MelonLogger.Msg("Harmony - Patching ScrapProduction ProcessGameResult...");
                harmony.Patch(AccessTools.Method(typeof(ScrapProduction), "ProcessGameResult"), new HarmonyMethod(typeof(Scrapper), "ProcessGameResult"));
                MelonLogger.Msg("Harmony - Patched ScrapProduction ProcessGameResult!");
            }
            catch (Exception ex)
            {
                MelonLogger.Msg("Harmony - FAILED to Apply Patch's!");
                MelonLogger.Msg(ex.Message);
            }
        }
    }
}