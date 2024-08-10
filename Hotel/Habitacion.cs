using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Hotel
{
    public  class Habitacion
    {
        public Habitacion()
        {
        }

        public int  Numero { get; set; }
        public double Precio { get; set; }
        public bool Disponible { get; set; }
        public string  Nombres { get; set; }
        public string  Id { get; set; }

        public Habitacion(int numero, double precio, bool disponible, string nombres, string id)
        {
            Numero = numero;
            Precio = precio;
            Disponible = disponible;
            Nombres = nombres;
            Id = id;
        }

        
        public void CambiarDisponibilidad(bool disponible)
        {
            Disponible=disponible;
        }

        public void AsignarCliente(string nombreCliente)
        {
            Nombres= nombreCliente;
        }
        
        public void AgregarHabitacion( int numero, bool disponible, string nombre, double precio )
        {
            Numero = numero;
            Precio = precio;
            Disponible = disponible;
            Nombres = nombre;
          

        }

        public bool BuscarHabitacion( int habitacion)
        { 
            bool existe=true;
            if(habitacion != Numero ) {

                existe=false;
            }
            else
            {

            }
            return existe;
        }


        public void SolicitarInformacion()
        {

            Console.Write("Numero de Habitacion: ");
            int numeroHabitacion = Convert.ToInt32(Console.ReadLine());
            Console.Write("Precio: ");
            double precio = Convert.ToDouble(Console.ReadLine());
            bool disponible = true;
            string nombre = "N/A";
           AgregarHabitacion(numeroHabitacion, disponible, nombre, precio);

        }

        public  void MostrarInformacion()
        {
            string disponible = "si";
            if (Disponible != true)
            {
                disponible = "No";
            }
            Console.WriteLine($"Habitación {Numero} - Disponible: {disponible} -Precio: {Precio} Cliente: {Nombres}");
        }


    }
}
