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

        List<PublicTransport> Transports = new List<PublicTransport>();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            Transports.Add(new Taxi(Convert.ToInt32(taxi1.Value)));
            Transports.Add(new Taxi(Convert.ToInt32(taxi2.Value)));
            Transports.Add(new Taxi(Convert.ToInt32(taxi3.Value)));
            Transports.Add(new Taxi(Convert.ToInt32(taxi4.Value)));
            Transports.Add(new Taxi(Convert.ToInt32(taxi5.Value)));

            Transports.Add(new Bus(Convert.ToInt32(bus1.Value)));
            Transports.Add(new Bus(Convert.ToInt32(bus2.Value)));
            Transports.Add(new Bus(Convert.ToInt32(bus3.Value)));
            Transports.Add(new Bus(Convert.ToInt32(bus4.Value)));
            Transports.Add(new Bus(Convert.ToInt32(bus5.Value)));
        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            FormShow formShow = new FormShow(Transports);
            formShow.ShowDialog();
        }
    }
}
