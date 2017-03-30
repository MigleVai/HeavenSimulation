using PirmasTOPMigle.Enums;
using PirmasTOPMigle.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PirmasTOPMigle.Class
{
    class Angel
    {
        // enum _powerLevel;

        public double LevelHoly { get; set; }
        public string Name { get; set; }
        public PowerLevel Power { get; private set; } = PowerLevel.Developer;

        public Angel(double levelHoly, string name = "NameLess") // optional 
        {
            LevelHoly = levelHoly;
            Name = name;
        }

        public void HolyWhat()
        {
            int level = (int)LevelHoly;     //casting
            if (level > 100)
            {
                Power = PowerLevel.Archangel;
            }
            else if (level > 50 && level < 100)
            {
                Power = PowerLevel.Angel;
            }
            else
            {
                Power = PowerLevel.Devil;
            }
        }
        public int CheckID(Soul s) 
        {
            if (Power == PowerLevel.Angel || Power == PowerLevel.Archangel)
            {
                if (!s.Id.CheckString())
                {
                    s.Status = State.Hell;
                    return -1;
                }
                else
                {
                    if (s.Status == State.Abyss || s.Status == State.Purgatory)
                    {
                        s.Status = State.Heaven;
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            else
            {
                return 2;
            }
        }
    }
}
