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
            var employeeToDelete = context.Employees.Find(id);

            context.Employees.Remove(employeeToDelete);

            context.SaveChanges();
        }
        public void Update(Employees employee)
        {
            var employeeToUpdate = context.Employees.Find(employee.EmployeeID);

            employeeToUpdate.LastName = employeeToUpdate.LastName;

            context.SaveChanges();

        }
        public Employees GetById(int id)
        {
            return  context.Employees.Find(id);
        }
    }
}
