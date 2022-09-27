using Lab.EF.Common.Exceptions;
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
    public partial class FormUpdateEmployee : Form
    {
        public FormUpdateEmployee(int id)
        {
            InitializeComponent();
            this.id = id;

        }

        private EmployeesController _employeeController = new EmployeesController();

        public int id;
        private void FormUpdateEmployee_Load(object sender, EventArgs e)
        {
            Fill();
  
        }

        private void Fill()
        {
            var employee = _employeeController.GetById(id);
            labelID.Text = "ID:  " + Convert.ToString(employee.EmployeeID);
            textBoxFIRSTNAME.Text = employee.FirstName;
            textBoxLASTNAME.Text = employee.LastName;
            textBoxTITLE.Text = employee.Title;
            
            if(employee.BirthDate != null)
                dateTimePickerBIRTH.Value = (DateTime)employee.BirthDate;

            if(employee.HireDate != null)
                dateTimePickerHire.Value = (DateTime)employee.HireDate;
            
            textBoxADDRESS.Text = employee.Address;
            textBoxCITY.Text = employee.City;
            textBoxHOMEPHONE.Text = employee.HomePhone;
        }
        private void buttonSAVE_Click(object sender, EventArgs e)
        {
            try
            {
                string firstName = textBoxFIRSTNAME.Text;
                string lastName = textBoxLASTNAME.Text;
                string title = textBoxTITLE.Text;
                DateTime birthDate = dateTimePickerBIRTH.Value;
                DateTime hireDate = dateTimePickerHire.Value;
                string address = textBoxADDRESS.Text;
                string city = textBoxCITY.Text;
                string homePhone = textBoxHOMEPHONE.Text;

                EmployeeExceptions.ValidateEmployee(firstName, lastName, title);
                Employees employee = new Employees(id,firstName, lastName, title, 
                                        birthDate, hireDate, address, city, homePhone);

                string message = _employeeController.Update(employee);
                MessageBox.Show(message);

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void FormUpdateEmployee_Shown(object sender, EventArgs e)
        {
            textBoxFIRSTNAME.Focus();
        }
    }
}
