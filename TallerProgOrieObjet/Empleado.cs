using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerProgOrieObjet
{
    // Clase base Empleado
    
    public class Empleado
    {
        
        public string Nombre { get; set; }
        public double SalarioBase { get; set; }

        
        public Empleado(string nombre, double salarioBase)
        {
            Nombre = nombre;
            SalarioBase = salarioBase;
        }

        
        public virtual double CalcularSalario()
        {
            return SalarioBase;
        }

        
        public void MostrarInformacion()
        {
            Console.WriteLine($"Empleado: {Nombre}");
            Console.WriteLine($"Salario Base: ${SalarioBase:F2}");
        }
    }


    // Clase EmpleadoTiempoCompleto.
    public class EmpleadoTiempoCompleto : Empleado
    {
        public EmpleadoTiempoCompleto(string nombre, double salarioBase)
            : base(nombre, salarioBase)
        {
        }

        public override double CalcularSalario()
        {
            return SalarioBase;
        }
    }


    // Clase EmpleadoPorHoras.
    public class EmpleadoPorHoras : Empleado
    {
        
        public int HorasTrabajadas { get; set; }

        
        public EmpleadoPorHoras(string nombre, double salarioBase, int horasTrabajadas)
            : base(nombre, salarioBase)
        {
            HorasTrabajadas = horasTrabajadas;
        }

        
        public override double CalcularSalario()
        {
            return HorasTrabajadas * SalarioBase;
        }
    }
}
