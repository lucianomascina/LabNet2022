using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPoo
{
    public abstract class PublicTransport
    {
        public int Passengers { get; set; }

        public PublicTransport(int passengers)
        {
            Passengers = passengers;
        }
        public abstract string Move();
        public abstract string Stop();
    }
}
