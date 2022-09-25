using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab.EF.Logic.Controllers;

namespace Lab.EF.UI.Views.CustomerDemographics
{
    public partial class FormCustomerDemographics : Form
    {
        public FormCustomerDemographics()
        {
            InitializeComponent();
        }

        private CustomerDemographicsController _CustomerDemographics = new CustomerDemographicsController();
        private void FormCustomerDemographics_Load(object sender, EventArgs e)
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

        private void FillDataGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _CustomerDemographics.GetAll();
        }
    }
}
