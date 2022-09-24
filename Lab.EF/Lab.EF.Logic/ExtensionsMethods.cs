﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    public static class ExtensionsMethods
    {
        public static bool EmptyOrLetter(this string str)
        {
            decimal temp = 0;
            bool res = false;

            if (String.IsNullOrEmpty(str) || !decimal.TryParse(str, out temp))
            {
                res = true;
            }

            return res;
        }



    }
}
