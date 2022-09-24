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

namespace Lab.EF.UI.Views.Orders
{
    public partial class FormOrders : Form
    {
        public FormOrders()
        {
            InitializeComponent();
        }

        private OrdersController _ordersController = new OrdersController();

        private void FormOrders_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = _ordersController.GetAll();
             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
