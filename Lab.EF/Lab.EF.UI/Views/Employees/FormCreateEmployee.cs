using Lab.EF.Entities;
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
    public partial class FormCreateEmployee : Form
    {
        public FormCreateEmployee()
        {
            InitializeComponent();
        }

        private EmployeesController _employeecontroller = new EmployeesController();
        private void FormCreateEmployee_Load(object sender, EventArgs e)
        {

        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = textBoxNOMBRE.Text;
                string apellido = textBoxAPELLIDO.Text;

                Employees employee = new Employees(nombre,apellido);
                string message = _employeecontroller.Add(employee);
                MessageBox.Show(message);
              
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

