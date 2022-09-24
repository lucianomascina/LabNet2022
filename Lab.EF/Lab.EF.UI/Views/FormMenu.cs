using Lab.EF.UI.Views.Categories;
using Lab.EF.UI.Views.CustomerDemographics;
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
    }
}
