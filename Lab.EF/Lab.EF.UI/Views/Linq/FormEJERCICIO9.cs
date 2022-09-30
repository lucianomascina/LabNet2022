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
    public partial class FormEJERCICIO9 : Form
    {
        public FormEJERCICIO9()
        {
            InitializeComponent();
        }
        private ProductsController _productsController = new ProductsController();
        private void FormEJERCICIO9_Load(object sender, EventArgs e)
        {
            Fill();
        }

        public void Fill()
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = _productsController.GetAllOrderedByName();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
