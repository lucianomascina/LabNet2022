using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic.Controllers
{
    public class EmployeesController : IController<Employees>
    {
        private ILogic<Employees> _employeesLogic = new EmployeesLogic();
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
            string message = string.Empty;
          
            try
            {
                _employeesLogic.Add(entity);
              
                 message = "empleado agregado correctamente";
             
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return message;

        }
        public string Update(Employees entity)
        {
            string message = string.Empty;

            try
            {
                _employeesLogic.Update(entity);

                message = "empleado modificado correctamente";

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return message;

        }
        public string Delete(int id)
        {
            string message = string.Empty;
            
            try
            {
     
                _employeesLogic.Delete(id);

                message = "empleado borrado correctamente";

            }
            catch(DbUpdateException)
            {
                message = "no es posible eliminar el empleado, ya que se encuentra asociado a otra entidad";
            }
            catch (Exception ex)
            {
                throw ex;
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
