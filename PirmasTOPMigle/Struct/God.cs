using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PirmasTOPMigle.Helpers;
using PirmasTOPMigle.Class;

namespace PirmasTOPMigle.Struct
{
    struct God
    {
        private string _name;
        private int _angerSize;
        public God(string name)
        {
            _name = name;
            _angerSize = RandomGen.GenerateInt(0, 100);
        }

        public void PromoteAngel(Angel angel)
        {
            angel.HolyWhat();
        }

        public void StateOfSoul(Soul soul)
        {
            soul.GiveState();
        }

        public void ChangeStateOfSoul(Soul soul)
        {
            if (_angerSize > 10)
            {
                soul.ChangeState(_angerSize);
            }
        }
    }
}
