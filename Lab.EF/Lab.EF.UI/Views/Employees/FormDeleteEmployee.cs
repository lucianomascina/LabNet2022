using Lab.EF.Logic.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab.EF.UI
{
    public partial class FormDeleteEmployee : Form
    {
        private EmployeesController _employeeController = new EmployeesController();

        public int id;
        public FormDeleteEmployee(int id )
        {
            InitializeComponent();
            this.id = id;
        }

        private void Fill() 
        {
            var employee = _employeeController.GetById(id);
            label1.Text = "ID:  "+ Convert.ToString(employee.EmployeeID);
            label2.Text = "APELLIDO:  " + employee.LastName;
            label3.Text = "PAIS:  " + employee.Country;

        }
        
        private void FormDeleteEmployee_Load(object sender, EventArgs e)
        {
            Fill();
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                string message = _employeeController.Delete(id);
                MessageBox.Show(message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
        }
    }
}
