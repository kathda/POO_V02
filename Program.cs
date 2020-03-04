

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaProgramacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Apartamento apartamento = new Apartamento();
            bool next = true;
            string enter = "";

            while(next)
            {
                Console.Clear();
                Console.WriteLine("Bienvenidos ");
                Console.WriteLine("Seleccione la opcion que desee ");
                Console.WriteLine("1 Datos apartamento");
                Console.WriteLine("2 Vender apartamento");
                Console.WriteLine("3 Alquilar apartamento ");
                enter = Console.ReadLine();

                switch(enter)
                {
                    case "1":

                        Console.Clear();

                        Console.WriteLine("Agregar datos de Apartamento: ");
                        Console.WriteLine("Direccion: ");
                        apartamento.Direccion = Console.ReadLine();
                        Console.WriteLine("Color: ");
                        apartamento.Color = Console.ReadLine();
                        Console.WriteLine("Area de construccion: ");
                        apartamento.AreaConstruccion = Console.ReadLine();
                        Console.WriteLine("Parqueo: ");
                        apartamento.Parqueos = Console.ReadLine();
                        Console.WriteLine("Habitaciones: ");
                        apartamento.Habitaciones = Console.ReadLine();
                        Console.WriteLine("Baños: ");
                        apartamento.Banos = Console.ReadLine();
                        apartamento.Imprimir();
                        break;

                    case "2":

                        Console.Clear();
                        apartamento.Vender();
                        break;

                    case "3":
                        Console.Clear();

                        apartamento.Alquilar();
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Adios :(");
                        Console.ReadLine();
                        next = false;
                        break;

                    default:
                        Console.WriteLine("Algo anda mal :( elija la opcion correcta :)");
                        Console.ReadLine();
                        break;

                }
                Console.ReadKey();

            }
            
        }
    }
}
