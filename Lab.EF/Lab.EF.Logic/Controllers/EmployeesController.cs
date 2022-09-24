using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic.Controllers
{
    public class EmployeesController : IController<Employees>
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
        public string Add(Employees entity)
        {
            throw new NotImplementedException();
        }
        public string Update(Employees entity)
        {
            throw new NotImplementedException();
        }
        public string Delete(int id)
        {
            string message = string.Empty;
            
            try
            {
     
                _employeesLogic.Delete(id);

                message = "el cliente se borro correctamente";

            }
            catch (Exception ex)
            {
                message = ex.Message;
            }
            return message;
        }
        public Employees GetById(int id)
        {
            try
            {
                var employee = _employeesLogic.GetById(id);

                return (employee);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
     
    }
}
