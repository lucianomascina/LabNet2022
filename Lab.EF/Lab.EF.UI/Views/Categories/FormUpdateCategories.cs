using Lab.EF.Common.Exceptions;
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
    public partial class FormUpdateCategories : Form
    {
        public FormUpdateCategories(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        public int id;

        private CategoriesController _categoriesController = new CategoriesController();
        private void FormUpdateCategories_Load(object sender, EventArgs e)
        {
            Fill();
        }

        private void Fill()
        {
            var category = _categoriesController.GetById(id);
            labelID.Text = "ID: " + Convert.ToString(category.CategoryID);
            textBoxNAME.Text = category.CategoryName;
            textBoxDESCRIPTION.Text = category.Description;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBoxNAME.Text;
                string description = textBoxDESCRIPTION.Text;

                CategoryExceptions.ValidateCreateCategory(name);

                Entities.Categories category = new Entities.Categories(id,name, description);

                string message = _categoriesController.Update(category);
                MessageBox.Show(message);

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
