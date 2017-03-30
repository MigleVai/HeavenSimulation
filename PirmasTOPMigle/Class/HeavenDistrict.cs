using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PirmasTOPMigle.Class
{
    class HeavenDistrict<T>
    {

        private List<T> _heavenCitizens = new List<T>();
       
        public void AddCitizen(T citizen)
        {
            _heavenCitizens.Add(citizen);
        }

        public List<T> GetCitizens()
        {
            return _heavenCitizens;
        }

        public void RemoveCitizens(T a)
        {
            _heavenCitizens.Remove(a);
        }

        public int Size()
        {
            return _heavenCitizens.Count();
        }

        public T Get(int index)
        {
            return _heavenCitizens[index];
        }
    }
}

