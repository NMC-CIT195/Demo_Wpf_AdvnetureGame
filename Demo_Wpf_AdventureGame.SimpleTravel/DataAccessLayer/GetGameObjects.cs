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
        public static Player PlayerData()
        {
            return new Player()
            {
                Id = 1,
                ShortName = "Bonzo",
                Race = RaceName.Human,
                Age = 45,
                IsGalacticCitizen = true,
                IsActive = true,
                ExperiencePoints = 0
            };
        }

        public static Map MapData()
        {
            return new Map()
            {
                Id = 1,
                Name = "Level 1",
                Locations = new List<Location>()
                {
                    new Location()
                    {
                        Id = 1001,
                        Name = "Control Room",
                        IsAccessible = true,
                        ExperiencePoints = 10,
                        Description = "Your are standing in what appears to be a control room of some sort. Two walls are covered with glowing bluish monitors displaying what looks like data from various sensors. The text on the monitors uses a language that is unrecognizable. In the center of the room is a large hexagonal crystal pillar with a sloping top face. Walking up and touching the top of the crystal pillar causes the strange, hieroglyphic writings on it to fade out and then back again, but in a language that you can understand. There are names of locations on the ship and as your hand passes over each, they glow brightly. Looking around the room, you realize that there are no doors or windows and assume this must be a transportation device for moving about the ship."
                    },
                    new Location()
                    {
                        Id = 1002,
                        Name = "Power Stack",
                        IsAccessible = true,
                        ExperiencePoints = 10,
                        Description = "There is a low, barely audible hum permeating the room. Against one wall 10 metallic orange cylinders run floor to ceiling. They are roughly a meter in diameter and wrapped in a braided gold wire about as thick as your wrist."
                    },
                    new Location()
                    {
                        Id = 1003,
                        Name = "Recreation Room",
                        IsAccessible = false,
                        ExperiencePoints = 50,
                        Description = "A large room with many seats, tables, and strange pieces of equipment of various shapes and sizes. The room has a pungent odor, as if it had recently been occupied by someone."
                    }
                }
            };
        }
    }
}
