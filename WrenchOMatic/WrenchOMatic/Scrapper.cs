using Il2CppCMS.UI.Logic;
using UnityEngine;


namespace WrenchOMatic
{
    public class Scrapper : MonoBehaviour
    {
        public static bool MakeScrap(ref int amount)
        {
            amount *= Configurator._wrenchOSettings.Value.ScrapMultiplier;
            return true;
        }
        public static bool ProcessGameResult( ref BarType result)
        {
            if (Configurator._wrenchOSettings.Value.AlwaysBigBonus)
            {
                result = BarType.BigBonus;
            }
            return true;
        }
    }
}
