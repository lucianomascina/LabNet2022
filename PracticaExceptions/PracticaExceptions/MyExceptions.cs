using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExceptions
{
    public class MyExceptions
    {

        public static void Division1(decimal n1, decimal n2)
        {
            try
            {
                decimal result = n1 / n2;
                
            }
            catch(DivideByZeroException ex)
            {
                throw ex;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public static decimal Division2(decimal n1, decimal n2)
        {

            try
            {
                
                decimal result = n1 / n2;
                return result;
            }
            catch(DivideByZeroException ex)
            {
                throw new DivideByZeroException($"Solo Chuck Norris divide por cero! {ex.Message}");
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }
        

    }
}
