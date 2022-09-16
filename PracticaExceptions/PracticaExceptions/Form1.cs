using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaExceptions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                decimal n1 = numericUpDown1.Value;
                decimal n2 = numericUpDown2.Value;

                MyExceptions.Division1(n1, n2);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("operacion finalizada");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
