using PirmasTOPMigle.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PirmasTOPMigle.Class
{
    class Soul
    {
        public int SinAmount { get; set; } // auto-implemented
        public int GoodDeedAmount { get; set; }
        public string Id { get; private set; }
        public State Status { get; set; } = State.Abyss; 

        public Soul(int sinSize, int goodSize, string id = "Unidentified") // optional arg
        {
            SinAmount = sinSize;
            GoodDeedAmount = goodSize;
            Id = id;
        }

        public void GiveState()
        {
            double bad = (double)SinAmount / 2;
            double good = (double)GoodDeedAmount / 5;
            if (bad > 20 && good < 20)
            {
                Status = State.Hell;
            }
            else if (bad < 20 && good > 20 && good < 50)
            {
                Status = State.Purgatory;
            }
            else
            {
                Status = State.Heaven;
            }
        }

        public void ChangeState(int anger)
        {
            if (anger > 10 && anger < 60)
            {
                Status = State.Purgatory;
            }
            else
            {
                Status = State.Hell;
            }
        }
    }
} 
           
