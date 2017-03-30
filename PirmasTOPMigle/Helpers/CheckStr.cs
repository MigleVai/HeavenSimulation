using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PirmasTOPMigle.Helpers
{
    public static class CheckStr
    {
        public static bool CheckString(this string s)
        {
            Regex rgx = new Regex(@"^[a-zA-Z]\d{3}$");  // regex, extension method
            return rgx.IsMatch(s);
        }

        public static bool SizeString(this string s)
        {
            if (s.Length == 6)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
