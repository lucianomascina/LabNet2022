using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Common.Exceptions
{
    public class EmployeeExceptions
    {
        public static void ValidateCreateEmployee(string firstName, string lastNAME, string title,
                                            string city,string homephone)
        {
            ValidateFirstName(firstName);
            ValidateLastName(lastNAME);
            ValidateTitle(title);
            ValidateCity(city);
            ValidateHomephone(homephone);
        }
        public static void ValidateFirstName(string firstName)
        {
            if (firstName.EmptyOrNumber())
                throw new ArgumentException("debe ingresar un nombre");
        }
        
        public static void ValidateLastName(string lastNAME)
        {
            if (lastNAME.EmptyOrNumber())
                throw new ArgumentException("debe ingresar un apellido");
        }
        public static void ValidateTitle(string title)
        {
            if (title.IsNumber())
                throw new ArgumentException("el titulo no debe contener numeros");
        }

        public static void ValidateCity(string city)
        {
            if (city.IsNumber())
                throw new ArgumentException("la ciudad no debe contener numeros");
        }

        public static void ValidateHomephone(string homephone)
        {
            if (homephone.IsNotNumber())
                throw new ArgumentException("el telefono no debe contener letras");
        }

    }
}
