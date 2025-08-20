using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerProgOrieObjet
{

    using System;
    using System.Collections.Generic;

    public class RegistradorDeVehiculos
    {
        // Método para registrar un automóvil
        public void RegistrarAutomovil(List<Vehiculo> lista)
        {
            Console.Clear();
            Console.WriteLine("--- REGISTRAR AUTOMÓVIL ---");

            Console.Write("Ingrese la marca: ");
            string marca = Console.ReadLine();

            Console.Write("Ingrese el modelo: ");
            string modelo = Console.ReadLine();

            int anio = SolicitarNumero("el año");
            decimal precio = SolicitarDecimal("el precio");
            int puertas = SolicitarNumero("la cantidad de puertas");

            Automovil nuevoAuto = new Automovil(marca, modelo, anio, precio, puertas);
            lista.Add(nuevoAuto);
            Console.WriteLine("\n✅ ¡Automóvil registrado con éxito!");
        }

        // Método para registrar una motocicleta
        public void RegistrarMotocicleta(List<Vehiculo> lista)
        {
            Console.Clear();
            Console.WriteLine("--- REGISTRAR MOTOCICLETA ---");

            Console.Write("Ingrese la marca: ");
            string marca = Console.ReadLine();

            Console.Write("Ingrese el modelo: ");
            string modelo = Console.ReadLine();

            int anio = SolicitarNumero("el año");
            decimal precio = SolicitarDecimal("el precio");
            int cilindraje = SolicitarNumero("el cilindraje");

            Motocicleta nuevaMoto = new Motocicleta(marca, modelo, anio, precio, cilindraje);
            lista.Add(nuevaMoto);
            Console.WriteLine("\n✅ ¡Motocicleta registrada con éxito!");
        }

        private int SolicitarNumero(string mensaje)
        {
            int numero;
            while (true)
            {
                Console.Write($"Ingrese {mensaje}: ");
                if (int.TryParse(Console.ReadLine(), out numero))
                {
                    return numero;
                }
                Console.WriteLine($"\nEntrada inválida. Debe ser un número entero.");
            }
        }

        private decimal SolicitarDecimal(string mensaje)
        {
            decimal numero;
            while (true)
            {
                Console.Write($"Ingrese {mensaje}: ");
                if (decimal.TryParse(Console.ReadLine(), out numero))
                {
                    return numero;
                }
                Console.WriteLine($"\nEntrada inválida. Debe ser un valor numérico.");
            }
        }

        public static void MostrarInventario(List<Vehiculo> lista)
        {
            Console.Clear();
            Console.WriteLine("--- INVENTARIO DE LA CONCESIONARIA ---");

            if (lista.Count == 0)
            {
                Console.WriteLine("El inventario está vacío.");
                return;
            }

            foreach (Vehiculo vehiculo in lista)
            {
                vehiculo.MostrarInfo();
            }
        }
    }
}
