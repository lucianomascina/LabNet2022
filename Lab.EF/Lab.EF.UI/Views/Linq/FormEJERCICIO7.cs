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
    public partial class FormEJERCICIO7 : Form
    {
        public FormEJERCICIO7()
        {
            InitializeComponent();
        }

        private OrdersController _ordersController = new OrdersController();
        private void FormEJERCICIO7_Load(object sender, EventArgs e)
        {
            FillDataGrid();
        }

        private void FillDataGrid()
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = _ordersController.GetWhereCustomersRegionWA();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
