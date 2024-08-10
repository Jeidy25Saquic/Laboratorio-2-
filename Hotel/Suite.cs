using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    internal class Suite:Habitacion
    {
        int NumeroHabitaciones { get; set; } 
        bool TieneJacuzzi { get; set; }
        public void AgregarHabitacion(string id, bool jacuzzi, int numeroHabitacione)
        {
            Id = id;
            NumeroHabitaciones=numeroHabitacione;
            TieneJacuzzi = jacuzzi;

        }

        public void SolicitarInformacion()
        {
            base.SolicitarInformacion();
            bool jacuzz = true;
            string id = "suite";
            Console.Write(" Cuantas Habitaciomnes Posee: ");
            int habitaciones=Convert.ToInt32(Console.ReadLine());
            Console.Write(" Cuenta con jacuzz  [si] [no]: ");
            string tiene = Console.ReadLine().ToLower();
            if (tiene != "si")
            {
                jacuzz = false;
            }
            AgregarHabitacion(id, jacuzz,habitaciones);

        }

        public void MostrarInformacion()
        {
            string jacuzzi = "Si tiene";
            base.MostrarInformacion();
            if (TieneJacuzzi != true)
            {
                jacuzzi = "No tiene";
            }
            Console.Write($" Numero de Habitaciones {NumeroHabitaciones} Tipo de Habitacion: {Id}  Tiene Jacuzzi: {jacuzzi}  ");


        }
    }

}

