using Lab.EF.Entities;
using Lab.EF.Common.Exceptions;
using Lab.EF.Logic;
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

        private EmployeesController _employeeController = new EmployeesController();
        private void FormCreateEmployee_Load(object sender, EventArgs e)
        {

        }
      
        private void buttonCrear_Click(object sender, EventArgs e)
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

                EmployeeExceptions.ValidateCreateEmployee(firstName,lastName,title,city,homePhone);

                Employees employee = new Employees(firstName,lastName,title,
                                        birthDate,hireDate,address,city, homePhone);

                string message = _employeeController.Add(employee);
                MessageBox.Show(message);
                
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message);
            }

        }

        private void FormCreateEmployee_Shown(object sender, EventArgs e)
        {
            textBoxFIRSTNAME.Focus();
        }
    }
}

