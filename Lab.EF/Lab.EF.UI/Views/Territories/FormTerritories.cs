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

namespace Lab.EF.UI.Views.Territories
{
    public partial class FormTerritories : Form
    {
        public FormTerritories()
        {
            InitializeComponent();
        }

        private TerritoriesController _territoriescontroller = new TerritoriesController();
        private void FormTerritories_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = _territoriescontroller.GetAll();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
