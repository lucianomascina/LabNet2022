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

namespace Lab.EF.UI.Views.OrderDetails
{
    public partial class FormOrderDetails : Form
    {
        public FormOrderDetails()
        {
            InitializeComponent();
        }

        private OrderDetailsController _OrderDetailsController = new OrderDetailsController();

        private void FormOrderDetails_Load(object sender, EventArgs e)
        {
            try
            {
                FillDataGrid();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void FillDataGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _OrderDetailsController.GetAll();
            dataGridView1.Columns["Orders"].Visible = false;
            dataGridView1.Columns["Products"].Visible = false;

        }
    }
}
