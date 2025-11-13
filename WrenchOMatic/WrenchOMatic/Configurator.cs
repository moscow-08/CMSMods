
using Il2CppTheVegetationEngine;
using MelonLoader;
using MelonLoader.Preferences;
using System.Reflection;
using Tomlet;
using Tomlet.Models;
using WrenchOMatic.Models;
namespace WrenchOMatic
{
    public class Configurator
    {
        private static readonly string configFilename = "mods/wrenchsettings.cfg";

        public static MelonPreferences_Category _configCat;
        public static MelonPreferences_Entry<PlayerSettings> _wrenchOSettings;

        public Configurator()
        {
            _configCat = MelonPreferences.CreateCategory("WrenchOMatic");
            _configCat.SetFilePath(configFilename, autoload: false);
            _wrenchOSettings = _configCat.CreateEntry("PlayerSettings", new PlayerSettings(), null, "Main Settings for the mod");

            _configCat.LoadFromFile();
            _configCat.SaveToFile();
        }        
    }
}
