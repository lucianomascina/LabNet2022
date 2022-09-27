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
    public partial class FormMenuCustomers : Form
    {
        public FormMenuCustomers()
        {
            InitializeComponent();
        }

        private CustomersController _customerController = new CustomersController();
        private void buttonMostrar_Click(object sender, EventArgs e)
        {
           
        }

        private void FormMenuCustomers_Load(object sender, EventArgs e)
        {
            FillDataGrid();
            dataGridView1.Columns["Orders"].Visible = false;
            dataGridView1.Columns["Fax"].Visible = false;
            dataGridView1.Columns["PostalCode"].Visible = false;
            dataGridView1.Columns["ContactTitle"].Visible = false;
            dataGridView1.Columns["CutomerDemographics"].Visible = false;



        }

        private void FillDataGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _customerController.GetAll();
        }

   
    }
}
