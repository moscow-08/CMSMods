using MelonLoader;

[assembly: MelonInfo(typeof(WrenchOMatic.Core), "WrenchOMatic", "1.0.0", "Tyler", null)]
[assembly: MelonGame("Red Dot Games", "Car Mechanic Simulator 2021")]

namespace WrenchOMatic
{
    public class Core : MelonMod
    {
        public override void OnInitializeMelon()
        {
            LoggerInstance.Msg("Initialized.");
        }
        public override void OnApplicationStart()
        {
            LoaderConfig melonConfig = new LoaderConfig();
        }
    }
}