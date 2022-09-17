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
                decimal num1 = Convert.ToDecimal(textBox1.Text);
                decimal num2 = Convert.ToDecimal(textBox2.Text);
                decimal result;

                result = MyExceptions.Division2(num1,num2);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            finally
            {
                
            }
       

        }

        private void Form2_Load(object sender, EventArgs e)
        {

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
