using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrenchOMatic.Models
{
    public class PlayerSettings
    {
        public int ScrapMultiplier;
        public bool AlwaysBigBonus;
        public int ScrewSpeedMultiplier;
        public int InspectMultiplier;
        public int WalkingSpeedMultiplier;
        public int PartMovementMultiplier;
        public int ExperienceGainedMultiplier;
        public int MoneyGainedMultiplier;

        public PlayerSettings()
        {
            ScrapMultiplier = 1;
            AlwaysBigBonus = false;
            ScrewSpeedMultiplier = 1;
            InspectMultiplier = 1;
            WalkingSpeedMultiplier = 1;
            PartMovementMultiplier = 1;
            ExperienceGainedMultiplier = 1;
            MoneyGainedMultiplier = 1;
        }
    }
}
