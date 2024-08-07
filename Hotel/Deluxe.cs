using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    internal class Deluxe: Habitacion
    {
        public List<bool> Desayuno { get; set; } = new List<bool>();
        public List<bool> Spa { get; set; } = new List<bool>();



    }
}
