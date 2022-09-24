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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void buttonEmpleados_Click(object sender, EventArgs e)
        {
            FormMenuEmployees formEmpleados = new FormMenuEmployees();
            formEmpleados.ShowDialog();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void buttonClientes_Click(object sender, EventArgs e)
        {
            FormMenuCustomers formMenuCustomers = new FormMenuCustomers();
            formMenuCustomers.ShowDialog();
        }
    }
}
