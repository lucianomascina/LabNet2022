using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPoo
{
    public class Taxi : PublicTransport
    {
        public Taxi (int passengers) : base(passengers)
        {

        }
        public override string Move()
        {
            return "Moviendo el taxi";
        }
        public override string Stop()
        {
            return "Frenando el taxi";
        }
    }
}
