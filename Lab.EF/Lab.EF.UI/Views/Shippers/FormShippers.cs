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

namespace Lab.EF.UI.Views.Shippers
{
    public partial class FormShippers : Form
    {
        public FormShippers()
        {
            InitializeComponent();
        }

        private ShippersController _shipperscontroller = new ShippersController();
        private void FormShippers_Load(object sender, EventArgs e)
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
            dataGridView1.DataSource = _shipperscontroller.GetAll();
            dataGridView1.Columns["Orders"].Visible = false;

        }
    }
}
