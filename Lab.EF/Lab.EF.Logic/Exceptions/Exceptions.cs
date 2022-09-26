using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic.Exceptions
{
    public class Exceptions
    {
        public static void ValidateForm(string firstName,string lastNAME,string title,
                                        string titleOfCourtesy)
        {
            if(firstName.EmptyOrNumber())
                throw new ArgumentException("debe ingresar un nombre");
            if(lastNAME.EmptyOrNumber())
                throw new ArgumentException("debe ingresar un apellido");
            if (title.IsNumber())
                throw new ArgumentException("el titulo no debe contener numeros");
            if(titleOfCourtesy.IsNumber())
                throw new ArgumentException("el titulo de cortesia no debe contener numeros");


        }

        
        
    }            
}
