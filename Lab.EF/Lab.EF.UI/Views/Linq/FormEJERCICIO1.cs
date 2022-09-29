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

namespace Lab.EF.UI.Views.Linq
{
    public partial class FormEJERCICIO1 : Form
    {
        public FormEJERCICIO1()
        {
            InitializeComponent();
        }

        private CustomersController _customersController = new CustomersController();
        private void FormEJERCICIO1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonSEARCH_Click(object sender, EventArgs e)
        {
            try
            {
                string id = textBoxID.Text;

                CustomerExceptions.ValidateId(id);  
                Customers customer = _customersController.GetByIdString(id);

                labelCOMPANYNAME.Text = customer.CompanyName;
                labelCONTACTNAME.Text = customer.ContactName;
                labelADDRESS.Text = customer.Address;
                labelCITY.Text = customer.City;
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}

