using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerProgOrieObjet
{
    public class Producto
    {
        
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }

        
        public Producto(string nombre, double precio, int stock)
        {
            Nombre = nombre;
            Precio = precio;
            Stock = stock;
        }

        
        public virtual double AplicarDescuento()
        {
            return Precio;
        }

        
        public void MostrarInformacion()
        {
            Console.WriteLine($"Producto: {Nombre}, Precio: ${Precio:F2}, Stock: {Stock}");
        }
    }

    public class Electronico : Producto
    {
        public int GarantiaMeses { get; set; }

        public Electronico(string nombre, double precio, int stock, int garantia) : base(nombre, precio, stock)
        {
            GarantiaMeses = garantia;
        }

        
        public override double AplicarDescuento()
        {
            double precioConDescuento = Precio * 0.90;
            Console.WriteLine($"Descuento del 10% aplicado. Nuevo precio: ${precioConDescuento:F2}");
            return precioConDescuento;
        }
    }

    public class Ropa : Producto
    {
        public string Talla { get; set; }

        
        public Ropa(string nombre, double precio, int stock, string talla) : base(nombre, precio, stock)
        {
            Talla = talla;
        }

        
        public override double AplicarDescuento()
        {
            double precioConDescuento = Precio * 0.80;
            Console.WriteLine($"Descuento del 20% aplicado. Nuevo precio: ${precioConDescuento:F2}");
            return precioConDescuento;
        }
    }
}
