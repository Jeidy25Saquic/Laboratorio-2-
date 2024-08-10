using Hotel;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;

class Program
{


    static void Main(string[] args)
    {
        List<Habitacion> listaHabitaciones = new List<Habitacion>();
        Habitacion habitacion = new Habitacion();
        Administracion administracion = new Administracion();


        bool continuar = true;
        int opcion = 0;




        do
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("1. Agregar Habitación: ");
                Console.WriteLine("2.Eliminar Habitación: ");
                Console.WriteLine("3. Mostrar Habitaciones ");
                Console.WriteLine("4. Asignar Habitación a Cliente ");
                Console.WriteLine("5.Liberar Habitación:");
                Console.WriteLine("6.Salir");
                


                opcion = Convert.ToInt32(Console.ReadLine());
                while (opcion < 1 || opcion > 7)
                {
                    Console.WriteLine("Valor no esta en el rango...")
                        ; Console.WriteLine("Ingrese un valor: ");
                    opcion = Convert.ToInt32(Console.ReadLine());
                }
                switch (opcion)
                {
                    case 1:

                        switch (administracion.Agregar())
                        {
                            case 1:
                                Console.Clear();
                                Console.WriteLine("Habitación Simple:");
                                HabitacionSimple simple = new HabitacionSimple();
                                simple.SolicitarInformacion();
                                listaHabitaciones.Add(simple);
                                Console.WriteLine("..........................................................");


                                break;
                            case 2:
                                Console.Clear();
                                Console.WriteLine("Habitación Doble:");
                                Dobles dobles = new Dobles();
                                dobles.SolicitarInformacion();
                                listaHabitaciones.Add(dobles);
                                Console.WriteLine("..........................................................");

                                break;
                            case 3:
                                Console.Clear();
                                Console.WriteLine("Habitación Suite:");
                                Suite suite = new Suite();
                                suite.SolicitarInformacion();
                                listaHabitaciones.Add(suite);
                                Console.WriteLine("..........................................................");
                                break;
                                break;
                            case 4:
                                Console.Clear();
                                Console.WriteLine("Habitación Suite:");
                                Deluxe deluxe = new Deluxe();
                                deluxe.SolicitarInformacion();
                                listaHabitaciones.Add(deluxe);
                                Console.WriteLine("..........................................................");
                                break;

                        }

                        break;

                    case 2:

                        Console.Clear();

                        Console.WriteLine("Ingrese el numero de habitacion que dessea eliminar ");
                        int numero = Convert.ToInt32((Console.ReadLine()));
                        administracion.EliminarHabitacion(listaHabitaciones, numero);

                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Todas las habitaciones");
                        administracion.MostrarHabitaciones(listaHabitaciones);
                        break;
                    case 4:
                        Console.Clear();
                       administracion.AsignarCliente(listaHabitaciones);
                        break;
                        case 5:
                        Console.Clear();
                        administracion.Liberar(listaHabitaciones);
                        break;
                    case 6:

                        continuar = false;

                        break;




                }


            }
            catch (Exception ex)
            {
                Console.WriteLine("Ha ocurrido un error... " + ex.Message);

            }


        } while (continuar == true);


    }


    
}