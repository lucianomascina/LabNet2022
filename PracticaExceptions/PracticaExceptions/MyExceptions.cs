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
        public static decimal Division2(string n1, string n2)
        {
            try
            {
                if (MyExtensions.EmptyOrLetter(n1,n2))
                {
                    throw new ArgumentException("Seguro Ingreso una letra o no ingreso nada!");
                }

                decimal result = Convert.ToDecimal(n1) / Convert.ToDecimal(n2);
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
            throw new CustomException("Excepción personalizada ejercicio 4");
        }
    }
}
