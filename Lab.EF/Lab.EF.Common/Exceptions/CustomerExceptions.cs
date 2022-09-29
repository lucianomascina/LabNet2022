using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Common.Exceptions
{
    public class CustomerExceptions
    {
        public static void ValidateIdCustomer(string id)
        {
            ValidateId(id);
        }

        public static void ValidateId(string id)
        {
            if (id.EmptyOrNumber())
                throw new ArgumentException("debe ingresar letras");
        }

    }
}
