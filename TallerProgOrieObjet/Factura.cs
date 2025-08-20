using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerProgOrieObjet
{
    public abstract class Factura
    {
        public int NumeroFactura { get; set; }
        public string Cliente { get; set; }
        public double Total { get; set; }

        public Factura(int numeroFactura, string cliente, double total)
        {
            NumeroFactura = numeroFactura;
            Cliente = cliente;
            Total = total;
        }

        public abstract void GenerarFactura();
    }

    public class FacturaElectronica : Factura
    {
        public FacturaElectronica(int numeroFactura, string cliente, double total) : base(numeroFactura, cliente, total) { }

        public override void GenerarFactura()
        {
            Console.WriteLine($"Factura #{NumeroFactura} para {Cliente}: Factura enviada por correo electrónico.");
        }
    }

    public class FacturaFisica : Factura
    {
        public FacturaFisica(int numeroFactura, string cliente, double total) : base(numeroFactura, cliente, total) { }

        public override void GenerarFactura()
        {
            Console.WriteLine($"Factura #{NumeroFactura} para {Cliente}: Factura impresa.");
        }
    }

    // Variable global o estática para el contador de facturas
    public static class FacturaManager
    {
        public static int ContadorFacturas = 100; // Puedes empezar en el número que desees
    }

}
