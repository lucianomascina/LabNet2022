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

        private void buttonVerTodos_Click(object sender, EventArgs e)
        {
            FormShowEmployees formMostrarEmpleados = new FormShowEmployees();
            formMostrarEmpleados.ShowDialog();
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            FormDeleteEmployee formBorrarEmpleado = new FormDeleteEmployee();
            formBorrarEmpleado.ShowDialog();
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            FormUpdateEmployee formActualizarEmpleado = new FormUpdateEmployee();
            formActualizarEmpleado.ShowDialog();
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            FormCreateEmployee formCrearEmpleado = new FormCreateEmployee();
            formCrearEmpleado.ShowDialog();
        }

        private void FormMenuEmployees_Load(object sender, EventArgs e)
        {

        }
    }
}
