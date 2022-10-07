using Lab.EF.Entities;
using Lab.EF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Services
{
    public class EmployeeService : IService<Employees>
    {
        private ILogic<Employees> _employeesLogic = new EmployeesLogic();

        public void Add(Employees entity)
        {
            _employeesLogic.Add(entity);
        }

        public void Delete(int id)
        {
            _employeesLogic.Delete(id);
        }

        public async Task<List<Employees>> GetAll()
        {
            return await _employeesLogic.GetAll();
        }

        public async Task<Employees> GetById(int id)
        {
            return await _employeesLogic.GetById(id);
        }

        public void Update(Employees entity)
        {
            _employeesLogic.Update(entity);
        }
    }
}
