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

        }
        private void buttonSAVE_Click(object sender, EventArgs e)
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
                Employees employee = new Employees(id,firstName, lastName);
                string message = _employeeController.Update(employee);
                MessageBox.Show(message);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
