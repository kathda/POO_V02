using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaProgramacion
{
    class Apartamento
    {
        private string direccion;
        private string color;
        private string areaConstruccion;
        private string parqueos;
        private string habitaciones;
        private string banos;
        public void Imprimir()
        {
            Console.WriteLine("Caracteristicas: ");
            Console.WriteLine("Direccion " + direccion);
            Console.WriteLine("Color " + color);
            Console.WriteLine("Area de Construccion " + areaConstruccion);
            Console.WriteLine("Parqueo " + parqueos);
            Console.WriteLine("Habitaciones " + habitaciones);
            Console.WriteLine(" Baños " + banos);
            Console.ReadLine();
        }

        public string Direccion { get => direccion; set => direccion = value; }
        public string Color { get => color; set => color = value; }
        public string AreaConstruccion { get => areaConstruccion; set => areaConstruccion = value; }
        public string Parqueos { get => parqueos; set => parqueos = value; }
        public string Habitaciones { get => habitaciones; set => habitaciones = value; }
        public string Banos { get => banos; set => banos = value; }

        public void Vender()
        {
            Console.WriteLine("Apartamento vendido");
            Console.WriteLine();
            Console.WriteLine("Caracteristicas: ");
            Console.WriteLine("Direccion " +direccion);
            Console.WriteLine("Color " +color);
            Console.WriteLine("Area de construccion " +areaConstruccion);
            Console.WriteLine("Parqueos " + parqueos);
            Console.WriteLine("Habitaciones " +habitaciones);
            Console.WriteLine("Baños " +banos);
            Console.ReadLine();

        }
        public void Alquilar()
        {
            Console.WriteLine("Apartamento alquilado");
            Console.WriteLine();
            Console.WriteLine("Caracteristicas: ");
            Console.WriteLine("Direccion " + direccion);
            Console.WriteLine("Color " + color);
            Console.WriteLine("Area de construccion " + areaConstruccion);
            Console.WriteLine("Parqueos " + parqueos);
            Console.WriteLine("Habitaciones " + habitaciones);
            Console.WriteLine("Baños " + banos);
            Console.ReadLine();

        }

    }
}
