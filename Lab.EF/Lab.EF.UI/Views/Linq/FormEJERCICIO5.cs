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
    public partial class FormEJERCICIO5 : Form
    {
        public FormEJERCICIO5()
        {
            InitializeComponent();
        }

        private ProductsController _productsController = new ProductsController();
        private void FormEJERCICIO5_Load(object sender, EventArgs e)
        {
            try
            {
                var product = _productsController.GetFirstOrNull();
                MessageBox.Show(product.ProductName);
            }
            catch (NullReferenceException ex)
            {
                textBox1.Text = ex.Message + "    el producto con id 789 no existe";
            }

        }

        private void FormEJERCICIO5_Shown(object sender, EventArgs e)
        {
           
        }
    }
}
