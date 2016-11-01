using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EjemploPersona
{
    public class Persona2
    {
        public string nombre { get; set; }

        public string frase { get; set; }

        public string apellido1 { get; }

        public readonly string apellido2;

        public int edad { get; private set; }

        public static int personas = 0;

        private string dni;

        public string serie
        {
            get { return dni; }
            set { dni = value; }
        }

        public Persona2(string nombre, int edad, string apellido1, string apellido2, string dni)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.apellido1 = apellido1;
            this.apellido2 = apellido2;
            this.dni = dni;
            personas++;
        }

        //public override bool Equals(object p)
        //{
        //    Persona personObj = p as Persona;
        //    if (personObj.dni == this.dni)
        //        return true;
        //    return false;
        //}

        ~Persona2() { }
    }
}