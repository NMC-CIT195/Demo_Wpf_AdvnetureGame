using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo_Wpf_AdventureGame.Models;

namespace Demo_Wpf_AdventureGame.DataAccessLayer
{
    public static class GetGameObjects
    {
        public static Player PlayerInformation()
        {
            return new Player()
            {
                Id = 1,
                ShortName = "Bonzo",
                Race = RaceName.Human,
                Age = 45,
                IsGalacticCitizen = true,
                IsActive = true,
                CurrentLocation = new MapCoordinates(0, 0),
                ExperiencePoints = 10
            };
        }
    }
}
