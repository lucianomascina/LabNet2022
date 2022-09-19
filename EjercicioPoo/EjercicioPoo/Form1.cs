using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioPoo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        
        }

        List<Taxi> Taxis = new List<Taxi>();
        List<Bus> Buses = new List<Bus>();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            int passengers = Convert.ToInt32(numericPassengers.Value);
          

        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            if((Taxis.Count == 0) && (Buses.Count == 0))
            {
                MessageBox.Show("No hay transportes para mostrar");
            }
            else
            {
                FormShow formShow = new FormShow(Taxis, Buses);
                formShow.ShowDialog();
            }
                
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
