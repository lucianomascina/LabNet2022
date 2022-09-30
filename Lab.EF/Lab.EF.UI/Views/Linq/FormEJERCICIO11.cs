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
    public partial class FormEJERCICIO11 : Form
    {
        public FormEJERCICIO11()
        {
            InitializeComponent();
        }

        private CategoriesController _categoriesController = new CategoriesController();
        private void FormEJERCICIO11_Load(object sender, EventArgs e)
        {
            Fill();
        }
        public void Fill()
        {
            try
            {
                dataGridView1.DataSource = null;
                //dataGridView1.DataSource = _categoriesController.GetAllHaveProducts();
                dataGridView1.Columns["Picture"].Visible = false;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
