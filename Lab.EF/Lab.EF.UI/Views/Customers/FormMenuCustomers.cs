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
            Fill();
            
        }

        private void Fill()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _customerController.GetAll();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
