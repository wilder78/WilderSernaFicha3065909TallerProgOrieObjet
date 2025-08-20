using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerProgOrieObjet
{

    using System;

    // Clase base
    public class Vehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Anio { get; set; }
        public decimal Precio { get; set; }

        public Vehiculo(string marca, string modelo, int anio, decimal precio)
        {
            Marca = marca;
            Modelo = modelo;
            Anio = anio;
            Precio = precio;
        }

        public virtual void MostrarInfo()
        {
            Console.WriteLine($"--- Información del Vehículo ---");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Año: {Anio}");
            Console.WriteLine($"Precio: ${Precio:N0}");
        }
    }

    // Clase Automovil
    public class Automovil : Vehiculo
    {
        public int CantidadPuertas { get; set; }

        public Automovil(string marca, string modelo, int anio, decimal precio, int cantidadPuertas)
            : base(marca, modelo, anio, precio)
        {
            CantidadPuertas = cantidadPuertas;
        }

        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine($"Cantidad de Puertas: {CantidadPuertas}");
            Console.WriteLine("----------------------------------");
        }
    }

    // Clase Motocicleta
    public class Motocicleta : Vehiculo
    {
        public int Cilindraje { get; set; }

        public Motocicleta(string marca, string modelo, int anio, decimal precio, int cilindraje)
            : base(marca, modelo, anio, precio)
        {
            Cilindraje = cilindraje;
        }

        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine($"Cilindraje: {Cilindraje} cc");
            Console.WriteLine("----------------------------------");
        }
    }
}
