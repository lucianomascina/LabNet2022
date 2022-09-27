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
    public partial class FormDeleteCategories : Form
    {
        private CategoriesController _categoriesController = new CategoriesController();

        public int id;
        public FormDeleteCategories(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void Fill()
        {
            var category = _categoriesController.GetById(id);
            

        }

        private void FormDeleteCategories_Load(object sender, EventArgs e)
        {
            Fill();
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                string message = _categoriesController.Delete(id);
                MessageBox.Show(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
