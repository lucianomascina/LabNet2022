using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExceptions
{
    public static class MyExtensions
    {
        public static bool EmptyOrLetter(string n1, string n2)
        {
            decimal temp1 = 0;
            decimal temp2 = 0;
            bool res = false;

            if (String.IsNullOrEmpty(n1) || String.IsNullOrEmpty(n2) ||
                !decimal.TryParse(n1, out temp1) || !decimal.TryParse(n2, out temp2))
            {
                res = true;
            }

            return res;

        }
    }
}
