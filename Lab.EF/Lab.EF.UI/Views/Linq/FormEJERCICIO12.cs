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
    public partial class FormEJERCICIO12 : Form
    {
        public FormEJERCICIO12()
        {
            InitializeComponent();
        }

        private ProductsController _productsController = new ProductsController();
        private void FormEJERCICIO12_Load(object sender, EventArgs e)
        {
            Fill();
        }

        public void Fill()
        {
            try
            {
                var product = _productsController.GetFirstElement();

                labelID.Text =  product.ProductID.ToString();
                labelNAME.Text = product.ProductName;
                labelPRICE.Text = product.UnitPrice.ToString();
                labelSTOCK.Text = product.UnitsInStock.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
