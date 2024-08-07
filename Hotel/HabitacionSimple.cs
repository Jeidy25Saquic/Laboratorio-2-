using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    internal class HabitacionSimple:Habitacion
    {

        public List<int> NumeroCamas { get; set; } = new List<int>();


        public HabitacionSimple()
        {
           
        }
       

        public void AgregarHabitacion(string id, int numeroHabitacion, double precio,int numeroCamas, bool disponible, string nombre)
        {
            Id.Add(id);
            Numero.Add(numeroHabitacion);
            Precio.Add(precio);
            NumeroCamas.Add(numeroCamas);
            Disponible.Add(disponible);
            Nombres.Add(nombre);
        }
        public void SolicitarInformacion()
        {

            Console.WriteLine("Numero de Habitacion");
            int numeroHabitacion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Numero Precios");
            double precio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Numero de Cama");
            int numeroCamas = Convert.ToInt32(Console.ReadLine());
            string nombreCliente = "N/A";
            string Id = "simple";
            bool disponible = true;
            AgregarHabitacion(Id, numeroHabitacion, precio, numeroCamas, disponible, nombreCliente);
            }


       


    }


    }


