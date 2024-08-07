using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    internal class Suite:Habitacion
    {
        public List<int> NumeroHabitaciones { get; set; } = new List<int>();
        public List<bool> TieneJacuzzi { get; set; } = new List<bool>();

    }
}
