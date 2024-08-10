using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public  class Administracion
    {
        public  int Agregar()
        {
            int opcion = 0;
            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine(" Habitaciones: ");
                    Console.WriteLine("1. Habitacion Simple ");
                    Console.WriteLine("2. Habitacion Doble");
                    Console.WriteLine("3. Suite ");
                    Console.WriteLine("4. Deluxe");
                    opcion = Convert.ToInt32(Console.ReadLine());

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ha ocurrido un error... " + ex.Message);
                }
            } while (opcion < 1 || opcion > 5);
            return opcion;
        }

        public  void AsignarCliente(List<Habitacion> listaHabitaciones)
        {
            Console.WriteLine("Ingrese el numero de habitacion que desea asignar ");
            int numero = Convert.ToInt32((Console.ReadLine()));
            Console.WriteLine("Nombre del cliente ");
            string nombre = Console.ReadLine().ToUpper();
            AsignarHabitacion(listaHabitaciones, numero, nombre);
        }

        public void Liberar (List<Habitacion> listaHabitaciones)
        {
            Console.WriteLine("Ingrese el numero de habitacion que desea liberar ");
            int numero = Convert.ToInt32((Console.ReadLine()));
            LiberarHabitacion(listaHabitaciones, numero);
          
        }

        public void MostrarHabitaciones(List<Habitacion> listaHabitaciones)
        {
            foreach (var habitacion in listaHabitaciones)
            {

                if (habitacion is HabitacionSimple simple)
                {
                    Console.WriteLine();
                    Console.WriteLine("Habitación Simple:");
                    simple.MostrarInformacion();
                    Console.WriteLine();
                }
                if (habitacion is Dobles dobles)
                {
                    Console.WriteLine();
                    Console.WriteLine("Habitación Doble:");
                    dobles.MostrarInformacion();
                    Console.WriteLine();
                }
                if (habitacion is Suite suite)
                {
                    Console.WriteLine();
                    Console.WriteLine("Habitación suite:");
                    suite.MostrarInformacion();
                    Console.WriteLine();
                }

                if (habitacion is Deluxe deluxe)
                {
                    Console.WriteLine();
                    Console.WriteLine("Habitación Deluxe:");
                    deluxe.MostrarInformacion();
                    Console.WriteLine();
                }
            }
        }

        public void EliminarHabitacion(List<Habitacion> listaHabitaciones, int numero)
        {
            bool existe = false;
            foreach (var habitacion in listaHabitaciones)
            {
                if (habitacion is HabitacionSimple simple)
                {


                    if (simple.BuscarHabitacion(numero) == true)
                    {
                        int posicion = listaHabitaciones.IndexOf(habitacion);
                        listaHabitaciones.RemoveAt(posicion);
                        Console.WriteLine($"Habitación con número {numero} eliminada correctamente.");
                        existe = true;
                        break;
                    }
                    Console.WriteLine();
                }
                if (habitacion is Dobles dobles)
                {

                    if (dobles.BuscarHabitacion(numero) == true)
                    {
                        int posicion = listaHabitaciones.IndexOf(habitacion);
                        listaHabitaciones.RemoveAt(posicion);
                        Console.WriteLine($"Habitación con número {numero} eliminada correctamente.");
                        existe = true;
                        break;
                    }
                }
                if (habitacion is Suite suite)
                {

                    if (suite.BuscarHabitacion(numero) == true)
                    {
                        int posicion = listaHabitaciones.IndexOf(habitacion);
                        listaHabitaciones.RemoveAt(posicion);
                        Console.WriteLine($"Habitación con número {numero} eliminada correctamente.");
                        existe = true;
                        break;
                    }
                }
                if (habitacion is Deluxe deluxe)
                {

                    if (deluxe.BuscarHabitacion(numero) == true)
                    {
                        int posicion = listaHabitaciones.IndexOf(habitacion);
                        listaHabitaciones.RemoveAt(posicion);
                        Console.WriteLine($"Habitación con número {numero} eliminada correctamente.");
                        existe = true;
                        break;
                    }
                }

            }

            if (existe == false)
            {
                Console.WriteLine($"No existe una habitacion con el numero {numero}");
            }


        }
        public void AsignarHabitacion(List<Habitacion> listaHabitaciones, int numero, string nombre)
        {
            bool existe = false;
            foreach (var habitacion in listaHabitaciones)
            {
                if (habitacion is HabitacionSimple simple)
                {


                    if (simple.BuscarHabitacion(numero) == true)
                    {
                        simple.AsignarCliente(nombre);
                        simple.CambiarDisponibilidad(false);
                        Console.WriteLine($"Habitación con número {numero} se asigno correctamente a {nombre}.");
                        existe = true;
                        break;
                    }
                    Console.WriteLine();
                }
                if (habitacion is Dobles dobles)
                {

                    if (dobles.BuscarHabitacion(numero) == true)
                    {
                        bool disponible = false;
                        dobles.AsignarCliente(nombre);
                        dobles.CambiarDisponibilidad(disponible);
                        Console.WriteLine($"Habitación con número {numero} se asigno correctamente a {nombre}.");
                        existe = true;

                        break;
                    }
                }
                if (habitacion is Suite suite)
                {

                    if (suite.BuscarHabitacion(numero) == true)
                    {

                        suite.AsignarCliente(nombre);
                        suite.CambiarDisponibilidad(false);
                        Console.WriteLine($"Habitación con número {numero} se asigno correctamente a {nombre}.");
                        existe = true;

                        break;
                    }

                }
                if (habitacion is Deluxe deluxe)
                {

                    if (deluxe.BuscarHabitacion(numero) == true)
                    {

                        deluxe.AsignarCliente(nombre);
                        deluxe.CambiarDisponibilidad(false);
                        Console.WriteLine($"Habitación con número {numero} se asigno correctamente a {nombre}.");
                        existe = true;

                        break;
                    }




                }

                if (existe == false)
                {
                    Console.WriteLine($"No existe una habitacion con el numero {numero}");
                }


            }

        }
        public void LiberarHabitacion(List<Habitacion> listaHabitaciones, int numero)
        {
            bool existe = false;
            foreach (var habitacion in listaHabitaciones)
            {
                if (habitacion is HabitacionSimple simple)
                {


                    if (simple.BuscarHabitacion(numero) == true)
                    {
                        
                        simple.AsignarCliente("N/A");
                        simple.CambiarDisponibilidad(true);
                        Console.WriteLine($"Habitación con número {numero}   libero correctamente.");
                        existe = true;
                        break;
                    }
                    Console.WriteLine();
                }
                if (habitacion is Dobles dobles)
                {

                    if (dobles.BuscarHabitacion(numero) == true)
                    {
                        bool disponible = false;
                        dobles.AsignarCliente("N/A"); ;
                        dobles.CambiarDisponibilidad(true);
                        Console.WriteLine($"Habitación con número {numero}   libero correctamente.");
                        existe = true;

                        break;
                    }
                }
                if (habitacion is Suite suite)
                {

                    if (suite.BuscarHabitacion(numero) == true)
                    {
                        bool disponible = false;
                        suite.AsignarCliente("N/A"); ;
                        suite.CambiarDisponibilidad(true);
                        Console.WriteLine($"Habitación con número {numero}   libero correctamente.");
                        existe = true;

                        break;
                    }
                }

                if(habitacion is Deluxe deluxe)
                {

                    if (deluxe.BuscarHabitacion(numero) == true)
                    {
                        bool disponible = false;
                        deluxe.AsignarCliente("N/A"); ;
                        deluxe.CambiarDisponibilidad(true);
                        Console.WriteLine($"Habitación con número {numero}   libero correctamente.");
                        existe = true;

                        break;
                    }
                }

            }

            if (existe == false)
            {
                Console.WriteLine($"No existe una habitacion con el numero {numero}");
            }


        }
    }
}
