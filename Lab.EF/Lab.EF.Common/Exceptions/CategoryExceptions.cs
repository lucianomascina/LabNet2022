using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Common.Exceptions
{
    public class CategoryExceptions
    {
        public static void ValidateCreateCategory(string name)
        {
            ValidateName(name);
        }

        public static void ValidateName(string name)
        {
            if (name.EmptyOrNumber())
                throw new ArgumentException("debe ingresar un nombre");
        }

    }
}
