using Hotel;

class Program
{


    static void Main(string[] args)
    {

        Habitacion habitacion = new Habitacion();

        bool continuar = true;
        int opcion = 0;




        do
        {
            try
            {
                Console.WriteLine("1. Agregar Habitación: ");
                Console.WriteLine("2.Eliminar Habitación: ");
                Console.WriteLine("3. Mostrar Habitaciones ");
                Console.WriteLine("4. Mostrar Habitaciones ");
                Console.WriteLine("5.Asignar Habitación a Cliente:");
                Console.WriteLine("6.Liberar Habitación");
                Console.WriteLine("7.Libera");


                opcion = Convert.ToInt32(Console.ReadLine());
                while (opcion < 1 || opcion > 4)
                {
                    Console.WriteLine("Valor no esta en el rango...")
                        ; Console.WriteLine("Ingrese un valor: ");
                    opcion = Convert.ToInt32(Console.ReadLine());
                }
                switch (opcion)
                {
                    case 1:

                        switch (Agregar())
                        {
                            case 1:
                                habitacion.BuscarInformacion();

                                break;
                            case 2:

                                break;
                            case 3:

                                break;

                        }

                        break;

                    case 2:
                        Console.WriteLine("Productos Disponibles");



                        break;
                    case 3:
                      
                        
                        break;
                    case 4:

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


    public static int Agregar()
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

}