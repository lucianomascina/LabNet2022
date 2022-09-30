﻿using Lab.EF.Logic.Controllers;
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
    public partial class FormEJERCICIO8 : Form
    {
        public FormEJERCICIO8()
        {
            InitializeComponent();
        }

        private CustomersController _customersController = new CustomersController();
        private void FormEJERCICIO8_Load(object sender, EventArgs e)
        {
            Fill();
        }

        public void Fill()
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = _customersController.GetTop3RegionWA();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
