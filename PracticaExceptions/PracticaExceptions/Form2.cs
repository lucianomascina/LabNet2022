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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                decimal result = MyExceptions.Division2(textBox1.Text, textBox2.Text);
                
                lblResult.Text = Convert.ToString(result);

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            finally
            {
                
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lblResult.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            lblResult.Text = "";

        }
    }
}
