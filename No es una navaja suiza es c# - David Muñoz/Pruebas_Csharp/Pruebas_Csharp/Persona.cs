using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas_Csharp
{
    class Persona
    {
        //Enumerable, por defecto será de tipo int, son válidos todos los tipos numéricos
        private enum generoEnum { Hombre, Mujer};

        generoEnum genero = generoEnum.Hombre;
        //Atributo nombre, con getter y setter
        public string nombre { get; set; }


        //Atributo de solo lectura
        public string apellido1 { get; } = "Fulano";


        //Atributo de solo lectura
        public readonly string apellido2;


        //Atributo edad, solo modificable desde la clase, no desde el exterior
        public int edad { get; private set; }


        //Atributo global, se accederá como Persona.personas
        public static int personas = 0;


        //Variable DNI, accesible desde otras clases como serie
        private string dni;

        public string serie
        {
            get { return dni; }
            set { dni = value; }
        }
        
        //Constructor de persona
        public Persona(string nombre, int edad, string apellido1, string apellido2, string dni)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.apellido1 = apellido1;
            this.apellido2 = apellido2;
            this.dni = dni;
            personas++;
        }

        //Segundo constructor de persona
        public Persona(string nombre, int edad, string apellido2, string dni)
        {

            this.nombre = nombre;
            this.edad = edad;
            this.apellido1 = apellido1;
            this.apellido2 = apellido2;
            this.dni = dni;
            personas++;
        }

        //Metodo que devuelve un string con  el sexo de la persona
        private string generoString ()
        {
            string cadena;
            switch (this.genero)
            {
                case generoEnum.Hombre:
                    cadena = "Hombre";
                    break;
                case generoEnum.Mujer:
                    cadena= "Mujer";
                    break;
                default:
                    cadena = "No genero";
                    break;
            }
            return cadena;
        }

        //Metodo toString para convertir un objeto a texto
        public override string ToString()
        {
            return this.nombre +" "+ this.generoString();
        }


        //Sobrecarga del metodo Equals, dos personas serán iguales si tienen el mismo DNI
        public override bool Equals(object p)
        {
            Persona personObj = p as Persona;
            if (personObj.dni == this.dni)
                return true;
            return false;
        }
        //Destructor, metodo no necesario a no ser que se quiera ejecutar alguna accion cuando se destruya el método
        ~Persona() { }
    }
}

