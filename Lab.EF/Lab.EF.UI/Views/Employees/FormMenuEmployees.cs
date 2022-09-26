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

namespace Lab.EF.UI
{
    public partial class FormMenuEmployees : Form
    {
        public FormMenuEmployees()
        {
            InitializeComponent();
        }

        private EmployeesController _employeeController = new EmployeesController();
        
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
        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if(id != null)
            {
                FormDeleteEmployee formDeleteEmployee = new FormDeleteEmployee((int)id);
                formDeleteEmployee.ShowDialog();
                FillDataGrid();
            }
         
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if(id != null)
            {
                FormUpdateEmployee formUpdateEmployee = new FormUpdateEmployee((int)id);
                formUpdateEmployee.ShowDialog();
                FillDataGrid();
            }
           
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            FormCreateEmployee formCreateEmployee = new FormCreateEmployee();
            formCreateEmployee.ShowDialog();
            FillDataGrid();
        }

        private void FormMenuEmployees_Load(object sender, EventArgs e)
        {
            try
            {
                FillDataGrid();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public void FillDataGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _employeeController.GetAll();
            dataGridView1.Columns["Photo"].Visible = false;
            dataGridView1.Columns["Employees1"].Visible = false;
            dataGridView1.Columns["Employees2"].Visible = false;
            dataGridView1.Columns["Orders"].Visible = false;
            dataGridView1.Columns["Territories"].Visible = false;
        }

    
    }
}
