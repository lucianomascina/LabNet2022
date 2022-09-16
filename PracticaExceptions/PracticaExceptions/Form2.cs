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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                /*decimal num1;
                decimal num2;
                decimal result;

                result = MyExceptions.Division2(num1,num2);
                lblResult.Text = Convert.ToString(result);*/
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            finally
            {
                lblFin.Text = "operacion finalizada";
            }
       

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            lblFin.Text = "";
            lblResult.Text = "";
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            lblFin.Text = "";
            lblResult.Text = "";
        }
    }
}
