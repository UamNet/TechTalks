using Pruebas_Csharp.Enums;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pruebas_Csharp
{
    class Program
    {

        //Estructura, Persona, si lo instancimos serán un valor no una refencia
        public struct Persona2
        {
            public string nombre { get; set; }

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
        }




        //El valor x no se verá modificado en la llamada
        static void suma(int x, int y)
        {
            x = x + y;
        }


        //El valor x se verá modificado en la llamada
        static void sumaRef(ref int x, int y)
        {
            x = x + y;
        }
        //z se instancia dentro del metodo
        static void sumaOut(int x, int y, out int z)
        {
            z = new int();
            z = x + y;
        }
        static void Main(string[] args)
        {
            int x = 1;
            int y = 2;
            int z;
            sumaOut( x, y,out z);
            Console.WriteLine(z);
            




            /////DICCIONARIO
            string frase = "En la casa de maria no hay perros sino gatos y ademas una lampara muy bonita";
            //Diccionario cuya clave es un char y valor int
            Dictionary<char, int> myDict = new Dictionary<char, int>();

            //Contamos en numero de apariciones de cada letra y lo guardamos en un diccionario
            foreach (char i in frase.ToLower())
            {
                try
                {
                    
                    myDict.Add(i, 1);
                }
                catch
                {
                    myDict[i]++;
                }
            }


            //Guardamos la letra el mayor ratio en la frase
            int max = -1;
            char myChar;

            foreach (KeyValuePair<char, int> kvp in myDict)
            {
                if (kvp.Value > max)
                {
                    max = kvp.Value;
                    myChar = kvp.Key;
                }
            }


            //Posicion de la a
            Console.WriteLine(myDict['a']);

            //////LISTAS


            //Lista con las diferentes letras
            List<char> lista = new List<char>();
            foreach (char i in frase)
            {
                if (!lista.Contains(i))
                    lista.Add(i);
            }

            foreach (char i in lista)
                Console.WriteLine(i);

            Console.WriteLine(lista[1]);
            /////PILAS

            Stack<int> b = new Stack<int>();
            b.Push(1);
            b.Push(2);
            b.Push(3);

            foreach (int i in b)
            {
                Console.WriteLine(i);
            }

            ////Colas

            Queue<int> c = new Queue<int>();
            c.Enqueue(1);
            c.Enqueue(2);
            c.Enqueue(3);

            foreach (int i in c)
            {
                Console.WriteLine(i);
            }

            

            //Imprime el valor del enum unom en la carpera ENUMS
            EnumExamples.imprimeEnum(myEnumInt.uno);
            //El arraylist contiene todos los tipos que queramos
            ArrayList arra = new ArrayList();
            arra.Add(new Persona("", 2, "", "", ""));
            arra.Add(1);
            Console.WriteLine(arra[0].ToString());
            Console.WriteLine("hay "+ Persona.personas+" Personas");
            //Instanciaciones
            Persona p2 = new Persona("menganito", 2, "perez", "wdauybndwuos");
            Persona p3 = new Persona("mariano", 1, "gomez", "sana", "eaff");
            Persona p4 = new Persona("menganito", 2, "perez", "wdauybndwuos");
            Console.WriteLine("hay " + Persona.personas + " Personas");
            Console.WriteLine(p2.apellido1);
            Persona2 p5 = new Persona2("David", 2, "Munoz", "Miranda", "wdauybndwuos");
            Console.WriteLine("hay " + Persona2.personas + " Personas2");

            Console.WriteLine(p2.ToString());


            //Dejamos el programa en pausa
            


            Console.ReadLine();
        }
    }
}
