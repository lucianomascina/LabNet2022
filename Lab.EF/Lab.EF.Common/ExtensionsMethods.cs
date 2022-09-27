using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Common
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

        public static bool IsNotNumber(this string str)
        {
            int temp = 0;
            bool res = true;

            if (int.TryParse(str, out temp) || String.IsNullOrEmpty(str))
            {
                res = false;
            }

            return res;
        }
    }
}
