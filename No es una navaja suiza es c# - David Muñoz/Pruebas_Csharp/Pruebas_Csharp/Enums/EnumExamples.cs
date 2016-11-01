using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas_Csharp.Enums
{
    public enum myEnumInt { uno, dos, tres };
    //byte, sbyte, short, ushort, int, uint, long, ulong
  
    public static class EnumExamples
    {
        
        
        public static void imprimeEnum(myEnumInt enumInt)
        {
            switch (enumInt)
            {
                case myEnumInt.uno:
                    Console.WriteLine("uno");
                    break;
                case myEnumInt.dos:
                    Console.WriteLine("dos");
                    break;
                case myEnumInt.tres:
                    Console.WriteLine("tres");
                    break;
                default:
                    break;
            }


        }

    }

   
        
}


