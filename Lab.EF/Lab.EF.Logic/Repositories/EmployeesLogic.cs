using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    public class EmployeesLogic : BaseLogic, IABMLogic<Employees>
    {
        public List<Employees> GetAll()
        {
           
            return  _context.Employees.ToList();
        }
        public void Add(Employees employee)
        {
            _context.Employees.Add(employee);

            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            /// Encuentra la PRIMER ocurrencia que coincida con la expresión entre paréntesis, si no 
            /// se encuentra valor arroja una excepción.
            //var employeeToDelete = context.Employees.First(e => e.EmployeeID == id);   

            /// Encuentra la PRIMER ocurrencia que coincida con la expresión entre paréntesis, si no 
            /// se encuentra valor devuelve un valor default (correspondiente al tipo de dato solicitado)
            //regionAEliminar = context.Region.FirstOrDefault(r => r.RegionID == id);

            /// Encuentra la UNICA ocurrencia que coincida con la expresión entre paréntesis, si no 
            /// se encuentra valor arroja una excepción. Si se encuentra más de un valor arroja una excepción.
            //regionAEliminar = context.Region.Single(r => r.RegionID == id);

            /// Encuentra la UNICA ocurrencia que coincida con la expresión entre paréntesis, si no 
            /// se encuentra valor devuelve un valor default (correspondiente al tipo de dato solicitado). Si se encuentra más de un valor arroja una excepción.
            //regionAEliminar = context.Region.SingleOrDefault(r => r.RegionID == id);
            
            var employeeToDelete = _context.Employees.Find(id);

            _context.Employees.Remove(employeeToDelete);

            _context.SaveChanges();
        }
        public void Update(Employees employee)
        {
            var employeeToUpdate = _context.Employees.Find(employee.EmployeeID);

            employeeToUpdate.LastName = employee.LastName;
            employeeToUpdate.FirstName = employee.FirstName;
            employeeToUpdate.Title = employee.Title;
            employeeToUpdate.TitleOfCourtesy = employee.TitleOfCourtesy;
            employeeToUpdate.BirthDate = employee.BirthDate;
            employeeToUpdate.HireDate = employee.HireDate;
            employeeToUpdate.Address = employee.Address;
            employeeToUpdate.City = employee.City;
            employeeToUpdate.Region = employee.Region;
            employeeToUpdate.PostalCode = employee.PostalCode;
            employeeToUpdate.Country = employee.Country;
            employeeToUpdate.HomePhone = employee.HomePhone;
            employeeToUpdate.Extension = employee.Extension;
            employeeToUpdate.Notes = employee.Notes;
            

            _context.SaveChanges();

        }
        public Employees GetById(int id)
        {
            return  _context.Employees.Find(id);
        }
    }
}
