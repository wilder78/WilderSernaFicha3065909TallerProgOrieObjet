using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerProgOrieObjet
{
    
    public class Person : DataPersons
    {
        
        public override void MostrarDatos()
        {
            Console.WriteLine("==== Datos de la persona ====");
            Console.WriteLine($"Nombre: {this.names}");
            Console.WriteLine($"Edad: {this.age}");
            Console.WriteLine($"Documento: {this.document}");
            Console.WriteLine($"Mayor de edad: {EsMayorDeEdad()}");
        }

        
        public override bool EsMayorDeEdad()
        {
            return this.age >= 18;
        }
    }
}


