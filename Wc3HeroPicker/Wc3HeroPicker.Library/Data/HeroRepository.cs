using System.Collections.Generic;
using System.Linq;
using Wc3HeroPicker.Library.Models;

namespace Wc3HeroPicker.Library.Data
{
    public class HeroRepository
    {
        private readonly List<Hero> data;

        public HeroRepository()
        {
            data = Init();
        }

        public List<Hero> GetHerosHuman()
        {
            var retVal = data.Where(h => h.Race == Race.Human ||
                                         h.Race == Race.Neutral)
                             .ToList();

            return retVal;
        }

        public List<Hero> GetHerosOrc()
        {
            var retVal = data.Where(h => h.Race == Race.Orc ||
                                         h.Race == Race.Neutral)
                             .ToList();

            return retVal;
        }

        public List<Hero> GetHerosUndead()
        {
            var retVal = data.Where(h => h.Race == Race.Undead ||
                                         h.Race == Race.Neutral)
                             .ToList();

            return retVal;
        }

        public List<Hero> GetHerosNightelf()
        {
            var retVal = data.Where(h => h.Race == Race.Nightelf ||
                                         h.Race == Race.Neutral)
                             .ToList();

            return retVal;
        }

        private List<Hero> Init()
        {
            var list = new List<Hero>
            {
                new Hero { Name = "Alchemist", Race           = Race.Neutral },
                new Hero { Name = "Beastmaster", Race         = Race.Neutral },
                new Hero { Name = "Dark Ranger", Race         = Race.Neutral },
                new Hero { Name = "Firelord", Race            = Race.Neutral },
                new Hero { Name = "Naga Sea Witch", Race      = Race.Neutral },
                new Hero { Name = "Pandaren Brewmaster", Race = Race.Neutral },
                new Hero { Name = "Tinker", Race              = Race.Neutral },
                new Hero { Name = "Pitlord", Race             = Race.Neutral },

                new Hero { Name = "Archmage", Race      = Race.Human },
                new Hero { Name = "Blood Mage", Race    = Race.Human },
                new Hero { Name = "Mountain King", Race = Race.Human },
                new Hero { Name = "Paladin", Race       = Race.Human },

                new Hero { Name = "Blademaster", Race      = Race.Orc },
                new Hero { Name = "Far Seer", Race         = Race.Orc },
                new Hero { Name = "Shadow Hunter", Race    = Race.Orc },
                new Hero { Name = "Tauren Chieftain", Race = Race.Orc },

                new Hero { Name = "Crypt Lord", Race   = Race.Undead },
                new Hero { Name = "Death Knight", Race = Race.Undead },
                new Hero { Name = "Dreadlord", Race    = Race.Undead },
                new Hero { Name = "Lich ", Race        = Race.Undead },

                new Hero { Name = "Demon Hunter", Race        = Race.Nightelf },
                new Hero { Name = "Keeper of the Grove", Race = Race.Nightelf },
                new Hero { Name = "PotM", Race                = Race.Nightelf },
                new Hero { Name = "Warden", Race              = Race.Nightelf }
            };

            return list;
        }
    }
}