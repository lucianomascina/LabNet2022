using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic.Exceptions
{
    public class Exceptions
    {
        public static void ValidateFirstName(string firstName)
        {
            try
            {
                if (firstName.EmptyOrNumber())
                {
                    throw new ArgumentNullException("debe ingresar un nombre");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void ValidateLastName(string lastName)
        {
            if (lastName.EmptyOrNumber())
            {
                throw new ArgumentNullException("debe ingresar un apellido");
            }

        }
    }            
}
