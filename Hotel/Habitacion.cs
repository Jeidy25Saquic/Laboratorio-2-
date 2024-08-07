using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    internal class Habitacion
    {
        public List<int> Numero { get; set; } = new List<int>();
        public List<double> Precio { get; set; } = new List<double>();
       
        public List<bool> Disponible{ get; set; } = new List<bool>();

        public List<string> Nombres { get; set; } = new List<string>();
        public List<string> Id { get; set; } = new List<string>();

        public void BuscarInformacion()
        {

        }

        public bool CambiarDisponibilidad(bool disponible)
        {
            return disponible;
        }

        public void AsignarCliente(string nombreCliente)
        {

        }
        public void LiberarHabitacion()
        {

        }

        public void MostrarInformacion()
        {
            for (int i = 0; i < Numero.Count; i++)
            {
                Console.WriteLine("No. Habitacion" + Numero[i]);
                    Console.WriteLine("Precio" + Precio[i]);
                if (Disponible[i] == true)
                {
                    Console.WriteLine("Disponible");
                }
                else
                {
                    Console.WriteLine(" No Disponible");
                }

            }
        }

    }
}
