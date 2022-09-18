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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MyExceptions.ThrowCustom();
            }
            catch(CustomException ex)
            {
                textBox1.Text = ex.Message;
            }
            catch(Exception ex)
            {

            }
            finally
            {

            }

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
