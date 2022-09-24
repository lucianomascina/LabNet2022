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
           
            return  context.Employees.ToList();
        }
        public void Add(Employees employee)
        {
            context.Employees.Add(employee);

            context.SaveChanges();
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
            
            var employeeToDelete = context.Employees.Find(id);

            context.Employees.Remove(employeeToDelete);

            context.SaveChanges();
        }
        public void Update(Employees employee)
        {
            var employeeToUpdate = context.Employees.Find(employee.EmployeeID);

            employee.LastName = employeeToUpdate.LastName;

            context.Employees.Attach(employee);
            context.Entry(employee).State = EntityState.Modified;
            context.SaveChanges();

        }
        public Employees GetById(int id)
        {
            return  context.Employees.Find(id);
        }
    }
}
