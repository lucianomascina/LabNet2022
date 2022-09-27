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
                FillDataGrid();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private int? GetId()
        {
            try
            {
                return int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }

        }
        private void FillDataGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _categoriesController.GetAll();
            dataGridView1.Columns["Picture"].Visible = false;
            dataGridView1.Columns["Products"].Visible = false;
            dataGridView1.Columns[2].Width = 300;
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {

        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {

        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                FormDeleteCategories formDeleteCategories = new FormDeleteCategories((int)id);
                formDeleteCategories.ShowDialog();
                FillDataGrid();
            }
        }
    }
}
