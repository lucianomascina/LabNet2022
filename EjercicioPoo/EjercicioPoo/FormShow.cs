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
    public partial class FormShow : Form
    {
        List<Taxi> Taxis = new List<Taxi>();
        List<Bus> Buses = new List<Bus>();
        public FormShow(List<Taxi> taxis, List<Bus> buses)
        {
            InitializeComponent();
            this.Buses = buses;
            this.Taxis = taxis;
        }

        private void FormShow_Load(object sender, EventArgs e)
        {
            dataGridBus.DataSource = Buses;
            dataGridTaxi.DataSource = Taxis;

        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
