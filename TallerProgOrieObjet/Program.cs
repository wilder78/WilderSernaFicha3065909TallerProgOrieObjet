using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TallerProgOrieObjet
{
    
    
    public class Program
    {
        // Este codigo hace parte del ejercicio 3.
        //public static void MostrarInventario(List<Vehiculo> lista)
        //{
        //    Console.Clear();
        //    Console.WriteLine("--- INVENTARIO DE LA CONCESIONARIA ---");

        //    if (lista.Count == 0)
        //    {
        //        Console.WriteLine("El inventario está vacío.");
        //        return;
        //    }

        //    foreach (Vehiculo vehiculo in lista)
        //    {
        //        vehiculo.MostrarInfo();
        //    }
        //}

        static void Main(string[] args)
        {
            // ================================================== //
            //                  Ejercicio #1
            // ================================================== //
            //Person person = new Person();

            //Console.WriteLine("Ingrese su nombre:");
            //person.Nombre = Console.ReadLine();

            //Console.WriteLine("Ingrese su edad:");
            //person.Edad = int.Parse(Console.ReadLine());

            //Console.WriteLine("Ingrese su numero de identificacion:");
            //person.DocumentoID = Console.ReadLine();

            //person.MostrarDatos();

            //Console.ReadKey();

            // ================================================== //
            //                  Ejercicio #2
            // ================================================== //

            //CuentaBancaria miCuenta = new CuentaBancaria();

            // bool datosValidos = false;
            // decimal cantidadConsignar = 0;

            // do
            // {
            //     Console.Clear();

            //     Console.WriteLine("--- CREACIÓN DE CUENTA BANCARIA ---");

            //     // Ingresar el nombre del titular
            //     Console.WriteLine("Ingrese su nombre (no puede estar vacío):");
            //     miCuenta.Titular = Console.ReadLine();

            //     // Ingresar el número de cuenta
            //     Console.WriteLine("Ingrese su número de cuenta (debe ser numérico):");
            //     miCuenta.NumeroCuenta = Console.ReadLine();


            //     Console.WriteLine("Ingrese el dinero a consignar (debe ser un valor numérico y positivo):");
            //     string inputCantidad = Console.ReadLine();

            //     // Validar los datos ingresados
            //     if (!string.IsNullOrWhiteSpace(miCuenta.Titular) &&
            //         !string.IsNullOrWhiteSpace(miCuenta.NumeroCuenta) &&
            //         decimal.TryParse(inputCantidad, out cantidadConsignar) &&
            //         cantidadConsignar >= 0)
            //     {

            //         datosValidos = true;
            //         miCuenta.Saldo = cantidadConsignar;
            //         Console.WriteLine("\n¡Datos ingresados correctamente!");
            //         Console.WriteLine("Presione una tecla para continuar...");
            //         Console.ReadKey();
            //     }
            //     else
            //     {

            //         Console.WriteLine("\nERROR: Los datos ingresados son incorrectos. Por favor, inténtelo de nuevo.");
            //         Console.WriteLine("Presione una tecla para continuar...");
            //         Console.ReadKey();
            //     }
            // }
            // while (!datosValidos);


            // Console.Clear();
            // Console.WriteLine("--- CUENTA CREADA ---");
            // Console.WriteLine($"Titular: {miCuenta.Titular}");
            // Console.WriteLine($"Número de cuenta: {miCuenta.NumeroCuenta}");
            // miCuenta.MostrarSaldo();


            // miCuenta.Depositar(100);
            // miCuenta.Retirar(50);
            // miCuenta.MostrarSaldo();

            // ================================================== //
            //                  Ejercicio #3
            // ================================================== //

            // Descomentar el static void MostrarInventario en la parte superior.
            //List<Vehiculo> concesionaria = new List<Vehiculo>();

            //RegistradorDeVehiculos registrador = new RegistradorDeVehiculos();
            //int opcion;

            //do
            //{
            //    Console.Clear();
            //    Console.WriteLine("--- SISTEMA DE GESTIÓN DE VEHÍCULOS ---");
            //    Console.WriteLine("1. Registrar un Automóvil ");
            //    Console.WriteLine("2. Registrar una Motocicleta ");
            //    Console.WriteLine("3. Mostrar inventario ");
            //    Console.WriteLine("4. Salir ");
            //    Console.Write("\nIngrese su opción: ");

            //    if (int.TryParse(Console.ReadLine(), out opcion))
            //    {
            //        switch (opcion)
            //        {
            //            case 1:

            //                registrador.RegistrarAutomovil(concesionaria);
            //                break;
            //            case 2:

            //                registrador.RegistrarMotocicleta(concesionaria);
            //                break;
            //            case 3:

            //                MostrarInventario(concesionaria);
            //                break;
            //            case 4:
            //                Console.WriteLine("\nSaliendo del programa. ¡Hasta pronto!");
            //                break;
            //            default:
            //                Console.WriteLine("\nOpción no válida. Por favor, elija una opción del 1 al 4.");
            //                break;
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("\nEntrada inválida. Por favor, ingrese un número.");
            //    }

            //    if (opcion != 4)
            //    {
            //        Console.WriteLine("\nPresione cualquier tecla para volver al menú...");
            //        Console.ReadKey();
            //    }
            //} while (opcion != 4);

            // ================================================== //
            //                  Ejercicio #4
            // ================================================== //

            // Creamos la lista para almacenar los productos.
            //List<Producto> tienda = new List<Producto>();

            //int opcion;
            //double precioFinal = 0;

            //do
            //{
            //    Console.Clear();
            //    Console.WriteLine("--- SISTEMA DE GESTIÓN DE COMPRAS ---");
            //    Console.WriteLine("1. Comprar Electrodoméstico");
            //    Console.WriteLine("2. Comprar Ropa");
            //    Console.WriteLine("3. Salir del sistema");

            //    Console.Write("\nSeleccione una opción: ");

            //    if (int.TryParse(Console.ReadLine(), out opcion))
            //    {
            //        switch (opcion)
            //        {
            //            case 1:
            //                Console.Clear();
            //                Console.WriteLine("--- COMPRA DE ELECTRODOMÉSTICO ---");

            //                Electronico laptop = new Electronico("Laptop Gaming", 1800.00, 10, 24);

            //                precioFinal = laptop.AplicarDescuento();

            //                tienda.Add(laptop);

            //                Console.WriteLine("\n¡Laptop comprada!");
            //                Console.WriteLine($"Precio con descuento: ${precioFinal:F2}");
            //                Console.WriteLine("Presione una tecla para continuar...");
            //                Console.ReadKey();
            //                break;
            //            case 2:
            //                Console.Clear();
            //                Console.WriteLine("--- COMPRA DE ROPA ---");                            
            //                Ropa camiseta = new Ropa("Camiseta de Algodón", 30.00, 50, "L");

            //                precioFinal = camiseta.AplicarDescuento();

            //                tienda.Add(camiseta);

            //                Console.WriteLine("\n¡Camiseta comprada!");
            //                Console.WriteLine($"Precio con descuento: ${precioFinal:F2}");
            //                Console.WriteLine("Presione una tecla para continuar...");
            //                Console.ReadKey();
            //                break;
            //            case 3:
            //                Console.Clear();
            //                Console.WriteLine("Saliendo del sistema...");
            //                break;
            //            default:
            //                Console.WriteLine("\nOpción no válida. Por favor, elija una opción del 1 al 3.");
            //                Console.WriteLine("Presione una tecla para continuar...");
            //                Console.ReadKey();
            //                break;
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("\nEntrada inválida. Por favor, ingrese un número.");
            //        Console.WriteLine("Presione una tecla para continuar...");
            //        Console.ReadKey();
            //    }

            //} while (opcion != 3);

            //Console.Clear();
            //Console.WriteLine("--- RESUMEN DE COMPRAS ---");
            //if (tienda.Count == 0)
            //{
            //    Console.WriteLine("No se compraron productos.");
            //}
            //else
            //{
            //    foreach (var producto in tienda)
            //    {
            //        producto.MostrarInformacion();
            //    }
            //}

            // ================================================== //
            //                  Ejercicio #5
            // ================================================== //
            Console.Clear();
            Console.WriteLine("--- GESTIÓN DE EMPLEADOS ---");

            // Crear una instancia de EmpleadoTiempoCompleto
            EmpleadoTiempoCompleto empleado1 = new EmpleadoTiempoCompleto("Ana García", 2500.00);

            // Calcular y mostrar el salario
            double salarioAna = empleado1.CalcularSalario();
            empleado1.MostrarInformacion();
            Console.WriteLine($"Salario Mensual: ${salarioAna:F2}\n");

            // Crear una instancia de EmpleadoPorHoras
            EmpleadoPorHoras empleado2 = new EmpleadoPorHoras("Carlos López", 25.00, 160);

            // Calcular y mostrar el salario
            double salarioCarlos = empleado2.CalcularSalario();
            empleado2.MostrarInformacion();
            Console.WriteLine($"Horas Trabajadas: {empleado2.HorasTrabajadas}");
            Console.WriteLine($"Salario Mensual: ${salarioCarlos:F2}\n");

            // Opcional: Usar una lista para demostrar polimorfismo
            List<Empleado> listaEmpleados = new List<Empleado>();
            listaEmpleados.Add(empleado1); // Se puede añadir una instancia de EmpleadoTiempoCompleto
            listaEmpleados.Add(empleado2); // Se puede añadir una instancia de EmpleadoPorHoras

            Console.WriteLine("--- Cálculo de Salarios de la Lista ---");
            foreach (var empleado in listaEmpleados)
            {
                Console.WriteLine($"El salario de {empleado.Nombre} es: ${empleado.CalcularSalario():F2}");
            }

            Console.ReadKey();

        }

    }
    
}
