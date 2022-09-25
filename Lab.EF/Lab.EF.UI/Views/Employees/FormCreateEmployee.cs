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
                string firstName = textBoxFIRSTNAME.Text;
                string lastName = textBoxLASTNAME.Text;
                /*string title = textBoxTITLE.Text;
                string titleOfCourtesy = textBoxTITLEOFCOURTESY.Text;
                DateTime birthDate = dateTimePickerBIRTH.Value;
                DateTime hireDate = dateTimePickerHire.Value;
                string address = textBoxADDRESS.Text;
                string city = textBoxCITY.Text;
                string region = textBoxREGION.Text;
                string postalCode = textBoxPOSTALCODE.Text;
                string country = textBoxCOUNTRY.Text;
                string homePhone = textBoxHOMEPHONE.Text;
                string extension = textBoxEXTENSION.Text;
                Byte photo = Convert.ToByte(textBoxPHOTO.Text);
                string notes = textBoxNOTES.Text;
                string reportsTo = textBoxREPORTSTO.Text;
                string photoPath = textBoxPHOTOPATH.Text;*/

                /*Employees employee = new Employees(name,lastName,title,titleOfCourtesy,birthDate,
                                     hireDate,address,city,region,postalCode,country,homePhone,
                                     extension,photo,notes,reportsTo,photoPath);*/
                Employees employee = new Employees(firstName,lastName);
                string message = _employeecontroller.Add(employee);
                MessageBox.Show(message);
              
              
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message);
            }

        }

        private void FormCreateEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}

