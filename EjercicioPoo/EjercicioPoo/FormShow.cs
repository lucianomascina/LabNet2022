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
        List<PublicTransport> Transports = new List<PublicTransport>();
        public FormShow(List<PublicTransport> transports)
        {
            InitializeComponent();
            this.Transports = transports;
        }

        private void FormShow_Load(object sender, EventArgs e)
        {
            labelBus1.Text = $"{Transports[0].Passengers}  pasajeros";
            labelBus2.Text = $"{Transports[1].Passengers}  pasajeros";
            labelBus3.Text = $"{Transports[2].Passengers}  pasajeros";
            labelBus4.Text = $"{Transports[3].Passengers}  pasajeros";
            labelBus5.Text = $"{Transports[4].Passengers}  pasajeros";

            labelTaxi1.Text = $"{Transports[5].Passengers}  pasajeros";
            labelTaxi2.Text = $"{Transports[6].Passengers}  pasajeros";
            labelTaxi3.Text = $"{Transports[7].Passengers}  pasajeros";
            labelTaxi4.Text = $"{Transports[8].Passengers}  pasajeros";
            labelTaxi5.Text = $"{Transports[9].Passengers}  pasajeros";

        }

     
    }
}
