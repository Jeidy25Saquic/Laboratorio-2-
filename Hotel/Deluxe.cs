using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    internal class Deluxe: Habitacion
    {
        public Deluxe(int numero, double precio, bool disponible, string nombres, string id) : base(numero, precio, disponible, nombres, id)
        {
        }

        public Deluxe()
        {
        }

        public  bool Desayuno { get; set; } 
        public bool Spa { get; set; }

        public void AgregarHabitacion(string id, bool desayuno, bool spa)
        {
            Id = id;
            Spa = spa;
            Desayuno = desayuno;

        }

        public void SolicitarInformacion()
        {
            base.SolicitarInformacion();
            bool spa=true,desayuno=true;
            string id = "deluxe";
            Console.Write(" Cuenta con desayuno al mar [si] [no]: ");
            string tiene = Console.ReadLine().ToLower();
            if (tiene != "si")
            {
                desayuno= false;
            }
            Console.Write(" Cuenta spa vista al mar [si] [no]: ");
            string tienespa = Console.ReadLine().ToLower();
            if (tienespa != "si")
            {
                spa = false;
            }
            AgregarHabitacion(id, desayuno,spa);

        }

        public void MostrarInformacion()
        {
            string desayuno  = "Si tiene", spa= "Si tiene";
            base.MostrarInformacion();
            if (Desayuno != true)
            {
                desayuno = "No tiene";
            }
            if (Spa != true)
            {
                spa= "No tiene";
            }
            Console.Write($" Desayuno {desayuno}  -Tipo de Habitacion: {Id}   -Tiene Spa: {spa}  ");


        }

    }
}
