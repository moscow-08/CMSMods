using MelonLoader;
using System.Text.Json;
using WrenchOMatic.Models;
namespace WrenchOMatic
{
    public class Configurator
    {
        private static readonly string configFilename = "./settings.cfg";

        private static MelonPreferences_Category _configCat;

        public static MelonPreferences_Entry<int> _scrapMulti { get; set; }
        public static MelonPreferences_Entry<bool> _bigBonusOn { get; set; }
        public static MelonPreferences_Entry<int> _screwSpeedMulti { get; set; }
        public static MelonPreferences_Entry<int> _inspectMulti { get; set; }
        public static MelonPreferences_Entry<int> _walkSpeedMulti { get; set; }
        public static MelonPreferences_Entry<int> _partMoveMulti { get; set; }

        public Configurator()
        {
            _configCat = MelonPreferences.CreateCategory("PlayerSkillsMod");
            _configCat.SetFilePath(configFilename, autoload: true);

            if (!_configCat.HasEntry("ScrapMultiplier"))
            {
                _scrapMulti = _configCat.CreateEntry("ScrapMultiplier", 1, null, null, is_hidden: false, dont_save_default: false, null);
            }
            else
            {
                _scrapMulti = _configCat.GetEntry<int>("ScrapMultiplier");
            }
        }

        public static void ExtractConfigValues(MelonPreferences_Category settings)
        {
            
        }
        public static PlayerSettings MapSettingsConfig(MelonPreferences_Category playerSettings)
        {
        }
    }
}
