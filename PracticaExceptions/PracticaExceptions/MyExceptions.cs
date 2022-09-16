using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExceptions
{
    public class MyExceptions
    {
        public static decimal Division(decimal n1, decimal n2)
        {

            try
            {
                
                decimal result = n1 / n2;
                return result;
            }
            catch(DivideByZeroException ex)
            {
                throw new DivideByZeroException("No se puede dividir por cero");
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }
        

    }
}
