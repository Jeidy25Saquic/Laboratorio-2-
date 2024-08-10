using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    internal class Dobles: Habitacion
    {
        public Dobles(int numero, double precio, bool disponible, string nombres, string id) : base(numero, precio, disponible, nombres, id)
        {
        }

        public Dobles()
        {
          
        }

        public bool VistaMar { get; set; } 
        public void AgregarHabitacion(string id, bool vista)
        {
            Id = id;

            VistaMar = vista;

        }

        public void SolicitarInformacion()
        {
            base.SolicitarInformacion();
            bool vista = true;
            string id = "doble";
            Console.Write(" Cuenta con vista al mar [si] [no]: ");
            string tiene=Console.ReadLine().ToLower();
              if(tiene != "si")
            {
                vista = false;
            }
           AgregarHabitacion(id, vista);
           
        }

        public void MostrarInformacion()
        {
            string vista = "Si tiene";
            base.MostrarInformacion();
            if (VistaMar != true)
            {
                vista = "No tiene";
            }
            Console.Write($"Tipo de Habitacion: {Id}  Vista al mar: {vista} ");
           
          
        }
    }
}
