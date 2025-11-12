using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrenchOMatic.Models
{
    public class PlayerSettings
    {
        public double ScrapMultiplier;
        public bool AlwaysBigBonus;
        public double ScrewSpeedMultiplier;
        public double InspectMultiplier;
        public double WalkingSpeedMultiplier;
        public double PartMovementMultiplier;

        public PlayerSettings()
        {
            ScrapMultiplier = 1;
            AlwaysBigBonus = false;
            ScrewSpeedMultiplier = 1;
            InspectMultiplier = 1;
            WalkingSpeedMultiplier = 1;
            PartMovementMultiplier = 1;
        }
    }
}
