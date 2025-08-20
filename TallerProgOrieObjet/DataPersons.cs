using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerProgOrieObjet
{
    
    public abstract class DataPersons
    {
        protected string names;
        protected string document;
        protected int age;

        public string Nombre
        {
            get { return names; }
            set { names = value; }
        }

        public int Edad
        {
            get { return age; }
            set { age = value; }
        }

        public string DocumentoID
        {
            get { return document; }
            set { document = value; }
        }

        
        public abstract void MostrarDatos();
        public abstract bool EsMayorDeEdad();
    }
}
