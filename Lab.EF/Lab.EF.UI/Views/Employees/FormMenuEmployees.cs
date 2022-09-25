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

namespace Lab.EF.UI
{
    public partial class FormMenuEmployees : Form
    {
        public FormMenuEmployees()
        {
            InitializeComponent();
        }

        private EmployeesController _employeeController = new EmployeesController();
        
        private int? getid()
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
        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            int? id = getid();
            if(id != null)
            {
                FormDeleteEmployee formDeleteEmployee = new FormDeleteEmployee((int)id);
                formDeleteEmployee.ShowDialog();
            }
         
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            FormUpdateEmployee formUpdateEmployee = new FormUpdateEmployee();
            formUpdateEmployee.ShowDialog();
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            FormCreateEmployee formCreateEmployee = new FormCreateEmployee();
            formCreateEmployee.ShowDialog();
        }

        private void FormMenuEmployees_Load(object sender, EventArgs e)
        {
            try
            {
                Fill();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void Fill()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _employeeController.GetAll();
            dataGridView1.Columns["Photo"].Visible = false;
            dataGridView1.Columns["Employees1"].Visible = false;
            dataGridView1.Columns["Employees2"].Visible = false;
            dataGridView1.Columns["Orders"].Visible = false;
            dataGridView1.Columns["Territories"].Visible = false;
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
