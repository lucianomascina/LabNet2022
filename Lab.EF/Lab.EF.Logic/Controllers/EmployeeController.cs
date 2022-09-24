using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic.Controllers
{
    public class EmployeeController : IController<Employees>
    {
        private EmployeesLogic _employeesLogic = new EmployeesLogic();
        public List<Employees> GetAll()
        {
            List<Employees> employeesList = null;

            try
            {
                employeesList = _employeesLogic.GetAll();
                return employeesList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
