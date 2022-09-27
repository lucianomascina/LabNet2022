using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Common.Exceptions
{
    public class EmployeeExceptions
    {
        public static void ValidateEmployee(string firstName, string lastNAME, string title)
        {
            if (firstName.EmptyOrNumber())
                throw new ArgumentException("debe ingresar un nombre");
            if (lastNAME.EmptyOrNumber())
                throw new ArgumentException("debe ingresar un apellido");
            if (title.IsNumber())
                throw new ArgumentException("el titulo no debe contener numeros");

        }

       
    }
}
