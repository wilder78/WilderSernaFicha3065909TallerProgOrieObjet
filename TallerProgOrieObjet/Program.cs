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

        // ============================= // ======================================
        // Este codigo hace parte del ejercicio 6.
        //private static void CrearFactura(List<Factura> lista, string tipoFactura)
        //{

        //    FacturaManager.ContadorFacturas++;

        //    Console.Clear();
        //    Console.WriteLine($"--- CREAR FACTURA {tipoFactura.ToUpper()} ---");
        //    Console.WriteLine($"Número de factura: {FacturaManager.ContadorFacturas}");

        //    Console.Write("Ingrese el nombre del cliente: ");
        //    string cliente = Console.ReadLine();

        //    double totalFactura = 0;
        //    string respuesta;


        //    do
        //    {
        //        Console.WriteLine("Ingrese el nombre del producto");
        //        string nombre = Console.ReadLine();
        //        Console.Write("Ingrese el precio del producto: ");
        //        double precio = Convert.ToDouble(Console.ReadLine());
        //        totalFactura += precio;

        //        Console.Write("¿Desea agregar otro producto? (s/n): ");
        //        respuesta = Console.ReadLine().ToLower();

        //    } while (respuesta == "s");


        //    if (tipoFactura == "electronica")
        //    {
        //        FacturaElectronica nuevaFactura = new FacturaElectronica(FacturaManager.ContadorFacturas, cliente, totalFactura);
        //        lista.Add(nuevaFactura);
        //    }
        //    else if (tipoFactura == "fisica")
        //    {
        //        FacturaFisica nuevaFactura = new FacturaFisica(FacturaManager.ContadorFacturas, cliente, totalFactura);
        //        lista.Add(nuevaFactura);
        //    }

        //    Console.WriteLine($"\nFactura #{FacturaManager.ContadorFacturas} para {cliente} con un total de ${totalFactura:F2} creada con éxito.");
        //    Console.WriteLine("Presione una tecla para regresar al menú principal.");
        //    Console.ReadKey();
        //}

        // ============================= // ======================================
        // Este codigo hace parte del ejercicio 8.
        static List<IReservable> listaReservas = new List<IReservable>();
        private static void HacerReserva()
        {
            Console.Clear();
            Console.WriteLine("--- HACER UNA NUEVA RESERVA ---");
            Console.WriteLine("1. Habitación de Hotel");
            Console.WriteLine("2. Salón de Eventos");
            Console.Write("Seleccione el tipo de reserva: ");
            int tipoReserva = int.Parse(Console.ReadLine());

            if (tipoReserva == 1)
            {
                Console.Write("Ingrese el número de habitación: ");
                int numHabitacion = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el nombre del huésped: ");
                string nombreHuesped = Console.ReadLine();
                HabitacionHotel nuevaHabitacion = new HabitacionHotel(numHabitacion, nombreHuesped);
                listaReservas.Add(nuevaHabitacion);
                nuevaHabitacion.Reservar();
            }
            else if (tipoReserva == 2)
            {
                Console.Write("Ingrese el nombre del salón: ");
                string nombreSalon = Console.ReadLine();
                Console.Write("Ingrese el nombre del organizador: ");
                string nombreOrganizador = Console.ReadLine();
                SalonEventos nuevoSalon = new SalonEventos(nombreSalon, nombreOrganizador);
                listaReservas.Add(nuevoSalon);
                nuevoSalon.Reservar();
            }
            else
            {
                Console.WriteLine("Tipo de reserva no válido.");
            }
            Console.WriteLine("Presione una tecla para continuar.");
            Console.ReadKey();
        }

        private static void HacerCancelacion()
        {
            Console.Clear();
            Console.WriteLine("--- CANCELAR UNA RESERVA ---");
            if (listaReservas.Count == 0)
            {
                Console.WriteLine("No hay reservas para cancelar.");
                Console.ReadKey();
                return;
            }

            VerReservas();

            Console.Write("Ingrese el índice de la reserva a cancelar (empezando en 0): ");
            int indice = int.Parse(Console.ReadLine());

            if (indice >= 0 && indice < listaReservas.Count)
            {
                listaReservas[indice].CancelarReserva();
                listaReservas.RemoveAt(indice);
            }
            else
            {
                Console.WriteLine("Índice inválido.");
            }
            Console.WriteLine("Presione una tecla para continuar.");
            Console.ReadKey();
        }

        private static void VerReservas()
        {
            Console.Clear();
            Console.WriteLine("--- RESERVAS ACTIVAS ---");
            if (listaReservas.Count == 0)
            {
                Console.WriteLine("No hay reservas activas en este momento.");
            }
            else
            {
                for (int i = 0; i < listaReservas.Count; i++)
                {
                    var item = listaReservas[i];
                    Console.WriteLine($"[{i}] Tipo: {item.GetType().Name}");

                    if (item is HabitacionHotel habitacion)
                    {
                        Console.WriteLine($"    Habitación: {habitacion.NumeroHabitacion}, Huésped: {habitacion.NombreHuesped}");
                    }
                    else if (item is SalonEventos salon)
                    {
                        Console.WriteLine($"    Salón: {salon.NombreSalon}, Organizador: {salon.NombreOrganizador}");
                    }
                }
            }
            Console.WriteLine("Presione una tecla para continuar.");
            Console.ReadKey();
        }

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

            //List<Empleado> listaEmpleados = new List<Empleado>();
            //int opcion;

            //do
            //{
            //    Console.Clear();
            //    Console.WriteLine("--- SISTEMA DE GESTIÓN DE EMPLEADOS ---");
            //    Console.WriteLine("1. Registrar Empleado de Tiempo Completo");
            //    Console.WriteLine("2. Registrar Empleado por Horas");
            //    Console.WriteLine("3. Mostrar todos los salarios y salir");

            //    Console.WriteLine("\nSeleccione una opción: ");

            //    if (int.TryParse(Console.ReadLine(), out opcion))
            //    {
            //        switch (opcion)
            //        {
            //            case 1:                            
            //                Console.WriteLine("Ingrese el nombre del empleado:");
            //                string nombreCompleto = Console.ReadLine();
            //                Console.WriteLine("Ingrese el salario base:");
            //                double salarioCompleto = Convert.ToDouble(Console.ReadLine());

            //                EmpleadoTiempoCompleto nuevoEmpleadoCompleto = new EmpleadoTiempoCompleto(nombreCompleto, salarioCompleto);
            //                listaEmpleados.Add(nuevoEmpleadoCompleto);

            //                Console.WriteLine("Empleado registrado con éxito. Presione una tecla para continuar.");
            //                Console.ReadKey();
            //                break;

            //            case 2:

            //                Console.WriteLine("Ingrese el nombre del empleado:");
            //                string nombreHoras = Console.ReadLine();
            //                Console.WriteLine("Ingrese el valor por hora:");
            //                double salarioHoras = Convert.ToDouble(Console.ReadLine());
            //                Console.WriteLine("Ingrese la cantidad de horas trabajadas:");
            //                double horasTrabajadas = Convert.ToDouble(Console.ReadLine());

            //                EmpleadoPorHoras nuevoEmpleadoPorHoras = new EmpleadoPorHoras(nombreHoras, salarioHoras, horasTrabajadas);
            //                listaEmpleados.Add(nuevoEmpleadoPorHoras);

            //                Console.WriteLine("Empleado registrado con éxito. Presione una tecla para continuar.");
            //                Console.ReadKey();
            //                break;

            //            case 3:

            //                Console.Clear();
            //                Console.WriteLine("--- RESULTADOS FINALES ---");
            //                foreach (var empleado in listaEmpleados)
            //                {
            //                    Console.WriteLine($"El salario de {empleado.Nombre} es: ${empleado.CalcularSalario()}");
            //                }
            //                Console.WriteLine("\nSaliendo del sistema...");
            //                break;

            //            default:

            //                Console.WriteLine("Opción inválida. Por favor, intente de nuevo.");
            //                Console.ReadKey();
            //                break;
            //        }
            //    }
            //    else
            //    {

            //        Console.WriteLine("Entrada inválida. Por favor, ingrese un número.");
            //        Console.ReadKey();
            //        opcion = 0;
            //    }
            //} while (opcion != 3);

            // ================================================== //
            //                  Ejercicio #6
            // ================================================== //
            //List<Factura> listaFacturas = new List<Factura>();
            //int opcion;

            //do
            //{
            //    Console.Clear();
            //    Console.WriteLine("--- SISTEMA DE GESTIÓN DE FACTURAS ---");
            //    Console.WriteLine("1. Crear Factura Electrónica");
            //    Console.WriteLine("2. Crear Factura Física");
            //    Console.WriteLine("3. Mostrar todas las facturas y salir");
            //    Console.WriteLine("\nSeleccione una opción:");

            //    if (int.TryParse(Console.ReadLine(), out opcion))
            //    {
            //        switch (opcion)
            //        {
            //            case 1:
            //                // Lógica para crear una Factura Electrónica
            //                CrearFactura(listaFacturas, "electronica");
            //                break;

            //            case 2:
            //                // Lógica para crear una Factura Física
            //                CrearFactura(listaFacturas, "fisica");
            //                break;

            //            case 3:
            //                // Lógica para mostrar los resultados
            //                Console.Clear();
            //                Console.WriteLine("--- RESULTADOS FINALES ---");
            //                foreach (var factura in listaFacturas)
            //                {
            //                    factura.GenerarFactura();
            //                }
            //                Console.WriteLine("\nSaliendo del sistema...");
            //                break;

            //            default:
            //                Console.WriteLine("Opción inválida. Presione una tecla para continuar.");
            //                Console.ReadKey();
            //                break;
            //        }
            //    }
            //} while (opcion != 3);

            // ================================================== //
            //                  Ejercicio #7
            // ================================================== //

            //List<Publicacion> feed = new List<Publicacion>();
            //int opcion;

            //do
            //{
            //    Console.Clear();
            //    Console.WriteLine("--- SISTEMA DE PUBLICACIONES ---");
            //    Console.WriteLine("1. Crear Publicación de Texto");
            //    Console.WriteLine("2. Crear Publicación de Imagen");
            //    Console.WriteLine("3. Crear Publicación de Video");
            //    Console.WriteLine("4. Mostrar todas las publicaciones y salir");

            //    Console.WriteLine("\nSeleccione una opción: ");
            //    if (int.TryParse(Console.ReadLine(), out opcion))
            //    {
            //        switch (opcion)
            //        {
            //            case 1:
            //                // ingresar los dato de Texto
            //                Console.WriteLine("Ingrese el autor:");
            //                string autorTexto = Console.ReadLine();
            //                Console.WriteLine("Ingrese el contenido:");
            //                string contenidoTexto = Console.ReadLine();
            //                feed.Add(new PublicacionTexto(autorTexto, contenidoTexto));
            //                break;

            //            case 2:
            //                // Ingresar los datos de la Imagen
            //                Console.WriteLine("Ingrese el autor:");
            //                string autorImagen = Console.ReadLine();
            //                Console.WriteLine("Ingrese el contenido:");
            //                string contenidoImagen = Console.ReadLine();
            //                Console.WriteLine("Ingrese la URL de la imagen:");
            //                string urlImagen = Console.ReadLine();
            //                feed.Add(new PublicacionImagen(autorImagen, contenidoImagen, urlImagen));
            //                break;

            //            case 3:
            //                // Ingresar los datos de la url.
            //                Console.WriteLine("Ingrese el autor:");
            //                string autorVideo = Console.ReadLine();
            //                Console.WriteLine("Ingrese el contenido:");
            //                string contenidoVideo = Console.ReadLine();
            //                Console.WriteLine("Ingrese la URL del video:");
            //                string urlVideo = Console.ReadLine();
            //                Console.WriteLine("Ingrese la duración en segundos:");
            //                int duracion = int.Parse(Console.ReadLine());
            //                feed.Add(new PublicacionVideo(autorVideo, contenidoVideo, urlVideo, duracion));
            //                break;

            //            case 4:
            //                Console.WriteLine("\n Salida hasta pronto");
            //                break;

            //            default:
            //                Console.WriteLine("Opción inválida. Presione una tecla para continuar.");
            //                Console.ReadKey();
            //                break;
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Entrada inválida. Por favor, ingrese un número.");
            //        Console.ReadKey();
            //    }

            //} while (opcion != 4);

            //// Mostrar todas las publicaciones al salir
            //Console.Clear();
            //Console.WriteLine("--- FEED DE LA RED SOCIAL ---");
            //foreach (var publicacion in feed)
            //{
            //    publicacion.MostrarPublicacion();
            //    Console.WriteLine();
            //}

            // ================================================== //
            //                  Ejercicio #8
            // ================================================== //

            // Descomentar codigo en la parte superior para ejecutar este ejercicio.
            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("--- SISTEMA DE RESERVAS DE HOTEL ---");
                Console.WriteLine("1. Hacer una reserva");
                Console.WriteLine("2. Cancelar una reserva");
                Console.WriteLine("3. Ver todas las reservas");
                Console.WriteLine("4. Salir");
                Console.WriteLine("\nSeleccione una opción: ");

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            HacerReserva();
                            break;
                        case 2:
                            HacerCancelacion();
                            break;
                        case 3:
                            VerReservas();
                            break;
                        case 4:
                            Console.WriteLine("Saliendo del sistema...");
                            break;
                        default:
                            Console.WriteLine("Opción inválida. Presione una tecla para continuar.");
                            Console.ReadKey();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, ingrese un número.");
                    Console.ReadKey();
                }

            } while (opcion != 4);
        }

    }
    
}
