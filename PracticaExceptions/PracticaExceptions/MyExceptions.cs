using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExceptions
{
    public class MyExceptions
    {
        public static decimal Division1(decimal n1, decimal n2)
        {
            try
            {
                decimal result = n1 / n2;
                return result;
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
        public static decimal Division2(string s1, string s2)
        {
            try
            {
                if (s1.EmptyOrLetter() || s2.EmptyOrLetter())
                {
                    throw new ArgumentException("Seguro Ingreso una letra o no ingreso nada!");
                }

                decimal result = Convert.ToDecimal(s1) / Convert.ToDecimal(s2);
                return result;
            }
            catch(ArgumentException ex)
            {
                throw ex;
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
        public static void ThrowCustom()
        {
            throw new CustomException("excepción ejercicio 4");
        }
    }
}
