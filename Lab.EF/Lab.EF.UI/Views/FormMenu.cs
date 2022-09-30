using Lab.EF.UI.Views.Categories;
using Lab.EF.UI.Views.CustomerDemographics;
using Lab.EF.UI.Views.Linq;
using Lab.EF.UI.Views.OrderDetails;
using Lab.EF.UI.Views.Orders;
using Lab.EF.UI.Views.Shippers;
using Lab.EF.UI.Views.Suppliers;
using Lab.EF.UI.Views.Territories;
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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void buttonEmpleados_Click(object sender, EventArgs e)
        {
            FormMenuEmployees formEmpleados = new FormMenuEmployees();
            formEmpleados.ShowDialog();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void buttonClientes_Click(object sender, EventArgs e)
        {
            FormMenuCustomers formMenuCustomers = new FormMenuCustomers();
            formMenuCustomers.ShowDialog();
        }

        private void buttonCATEGORIAS_Click(object sender, EventArgs e)
        {
            FormCategories formCategories = new FormCategories();
            formCategories.ShowDialog();
        }

        private void buttonCUSTOMERDEMOGRAPHICS_Click(object sender, EventArgs e)
        {
            FormCustomerDemographics formCustomerDemographics = new FormCustomerDemographics();
            formCustomerDemographics.ShowDialog();
        }

        private void buttonORDERDETAILS_Click(object sender, EventArgs e)
        {
            FormOrderDetails formOrderDetails = new FormOrderDetails();
            formOrderDetails.ShowDialog();
        }

        private void buttonORDERS_Click(object sender, EventArgs e)
        {
            FormOrders formOrders = new FormOrders();
            formOrders.ShowDialog();
        }

        private void buttonSHIPPERS_Click(object sender, EventArgs e)
        {
            FormShippers formShippers = new FormShippers();
            formShippers.ShowDialog();
        }

        private void buttonSUPPLIERS_Click(object sender, EventArgs e)
        {
            FormSuppliers formSuppliers = new FormSuppliers();
            formSuppliers.ShowDialog();
        }

        private void buttonTERRITORIES_Click(object sender, EventArgs e)
        {
            FormTerritories formTerritories = new FormTerritories();
            formTerritories.ShowDialog();
        }

        private void buttonEJERCICIO1_Click(object sender, EventArgs e)
        {
            FormEJERCICIO1 formEJERCICIO1 = new FormEJERCICIO1();
            formEJERCICIO1.ShowDialog();
        }

        private void buttonEJERCICIO2_Click(object sender, EventArgs e)
        {
            FormEJERCICIO2 formEJERCICIO2 = new FormEJERCICIO2();
            formEJERCICIO2.ShowDialog();
        }

        private void buttonEJERCICIO3_Click(object sender, EventArgs e)
        {
            FormEJERCICIO3 formEJERCICIO3 = new FormEJERCICIO3();
            formEJERCICIO3.ShowDialog();
        }

        private void buttonEJERCICIO4_Click(object sender, EventArgs e)
        {
            FormEJERCICIO4 formEJERCICIO4 = new FormEJERCICIO4();
            formEJERCICIO4.ShowDialog();
        }

        private void buttonEJERCICIO5_Click(object sender, EventArgs e)
        {
            FormEJERCICIO5 formEJERCICIO5 = new FormEJERCICIO5();
            formEJERCICIO5.ShowDialog();
        }

        private void buttonEJERCICIO6_Click(object sender, EventArgs e)
        {
            FormEJERCICIO6 formEJERCICIO6 = new FormEJERCICIO6();
            formEJERCICIO6.ShowDialog();
        }

        private void buttonEJERCICIO7_Click(object sender, EventArgs e)
        {
            FormEJERCICIO7 formEJERCICIO7 = new FormEJERCICIO7();
            formEJERCICIO7.ShowDialog();
        }

        private void buttonEJERCICIO8_Click(object sender, EventArgs e)
        {
            FormEJERCICIO8 formEJERCICIO8 = new FormEJERCICIO8();
            formEJERCICIO8.ShowDialog();
        }

        private void buttonEJERCICIO9_Click(object sender, EventArgs e)
        {
            FormEJERCICIO9 formEJERCICIO9 = new FormEJERCICIO9();
            formEJERCICIO9.ShowDialog();
        }

        private void buttonEJERCICIO10_Click(object sender, EventArgs e)
        {
            FormEJERCICIO10 formEJERCICIO10 = new FormEJERCICIO10();
            formEJERCICIO10.ShowDialog();
        }

        private void buttonEJERCICIO11_Click(object sender, EventArgs e)
        {
            FormEJERCICIO11 formEJERCICIO11 = new FormEJERCICIO11();
            formEJERCICIO11.ShowDialog();
        }

        private void buttonEJERCICIO12_Click(object sender, EventArgs e)
        {
            FormEJERCICIO12 formEJERCICIO12 = new FormEJERCICIO12();
            formEJERCICIO12.ShowDialog();
        }

        private void buttonEJERCICIO13_Click(object sender, EventArgs e)
        {
            FormEJERCICIO13 formEJERCICIO13 = new FormEJERCICIO13();
            formEJERCICIO13.ShowDialog();
        }
    }
}
