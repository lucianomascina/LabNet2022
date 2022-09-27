using Lab.EF.Logic.Controllers;
using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab.EF.Common.Exceptions;

namespace Lab.EF.UI.Views.Category
{
    public partial class FormCreateCategories : Form
    {
        public FormCreateCategories()
        {
            InitializeComponent();
        }

        private CategoriesController _categoriesController = new CategoriesController();

        private void FormCreateCategories_Load(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBoxNAME.Text;
                string description = textBoxDESCRIPTION.Text;

                CategoryExceptions.ValidateCreateCategory(name); 

                Entities.Categories category = new Entities.Categories(name,description);

                string message = _categoriesController.Add(category);
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
