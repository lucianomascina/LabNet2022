using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPoo
{
    public class Bus : PublicTransport
    {
        public Bus(int passengers) : base(passengers)
        {

        }
        public override string Move()
        {
            return "Moviendo el autobus";
        }
        public override string Stop()
        {
            return "Frenando el autobus";
        }
    }
}
