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
    public partial class FormEJERCICIO6 : Form
    {
        public FormEJERCICIO6()
        {
            InitializeComponent();
        }

        private CustomersController _customersController = new CustomersController();
        private void FormEJERCICIO6_Load(object sender, EventArgs e)
        {
            try
            {
                FillDataGridMayus();
                FillDataGridMinus();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        public void FillDataGridMayus()
        {
            dataGridViewMayuscula.DataSource = null;
            dataGridViewMayuscula.DataSource = _customersController.GetAllNames().
                                                ConvertAll(c => new { NAMESTOUPPER = c.ToUpper() });
            dataGridViewMayuscula.Columns[0].Width = 200;
        }

        public void FillDataGridMinus()
        {
            dataGridViewMINUSCULA.DataSource = null;
            dataGridViewMINUSCULA.DataSource = _customersController.GetAllNames().
                                                ConvertAll(c => new {NAMESTOLOWER = c.ToLower() });
            dataGridViewMINUSCULA.Columns[0].Width = 200;
        }
    }
}
