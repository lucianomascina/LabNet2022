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
    public partial class FormEJERCICIO4 : Form
    {
        public FormEJERCICIO4()
        {
            InitializeComponent();
        }

        private CustomersController _customersController = new CustomersController();  
        private void FormEJERCICIO4_Load(object sender, EventArgs e)
        {
            try
            {
                FillDatGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void FillDatGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _customersController.GetAllByRegionWA();
        }

    }
}
