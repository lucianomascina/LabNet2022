using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    public static class ExtensionsMethods
    {
        public static bool EmptyOrNumber(this string str)
        {
            int temp = 0;
            bool res = false;

            if (String.IsNullOrEmpty(str) || int.TryParse(str, out temp))
            {
                res = true;
            }

            return res;
        }

        public static bool IsNumber(this string str)
        {
            int temp = 0;
            bool res = false;

            if (int.TryParse(str, out temp))
            {
                res = true;
            }

            return res;
        }

    }
}
