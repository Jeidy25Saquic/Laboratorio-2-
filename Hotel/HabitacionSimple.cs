using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public class HabitacionSimple : Habitacion
    {
        public HabitacionSimple(int numero, double precio, bool disponible, string nombres, string id) : base(numero, precio, disponible, nombres, id)
        {
        }

        public HabitacionSimple()
        {
        }

        public int NumeroCamas { get; set; }


        public void AgregarHabitacion(string id, int numeroCamas)
        {
           Id = id;
          NumeroCamas = numeroCamas;
            
          
        }

        public  void SolicitarInformacion()
        {
            base.SolicitarInformacion();
            Console.Write("Número de Camas: ");
            int numeroCamas = Convert.ToInt32(Console.ReadLine());
            string id = "simple";
            AgregarHabitacion (id, numeroCamas);
           
        }

        public void MostrarInformacion() { 

            base.MostrarInformacion();
            Console.WriteLine($"Numero de Camas {NumeroCamas} - Tipo de Habitacion: {Id}");

        }
       


    }
}


