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

namespace Lab.EF.UI.Views.Categories
{
    public partial class FormCategories : Form
    {
        public FormCategories()
        {
            InitializeComponent();
        }

        private CategoriesController _categoriesController = new CategoriesController();
        private void FormCategories_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = _categoriesController.GetAll();
                dataGridView1.Columns["Picture"].Visible = false;
                dataGridView1.Columns["Products"].Visible = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }

    }
}
