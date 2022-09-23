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
        public async Task<List<Employees>> GetAll()
        {
            return await context.Employees.ToListAsync();
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
        public async Task<Employees> GetById(int id)
        {
            return await context.Employees.FindAsync(id);
        }
    }
}
