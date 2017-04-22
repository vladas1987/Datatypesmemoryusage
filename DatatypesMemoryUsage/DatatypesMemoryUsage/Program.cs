using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatatypesMemoryUsage
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            float b = 8.57f;
            char c = 'a';
            Console.WriteLine("Integer a Value is :" + a);
            Console.WriteLine("Float b Value is :" + b);
            Console.WriteLine("Character c Value is :" + c);
            Console.WriteLine("Memory Usage of Different Datatypes");
            Console.WriteLine("Size of bool    : " + sizeof(bool));
            Console.WriteLine("Size of byte    : " + sizeof(byte));
            Console.WriteLine("Size of char    : " + sizeof(char));
            Console.WriteLine("Size of decimal : " + sizeof(decimal));
            Console.WriteLine("Size of double  : " + sizeof(double));
            Console.WriteLine("Size of float   : " + sizeof(float));
            Console.WriteLine("Size of int     : " + sizeof(int));
            Console.WriteLine("Size of long    : " + sizeof(long));
            Console.WriteLine("Size of sbyte   : " + sizeof(sbyte));
            Console.WriteLine("Size of short   : " + sizeof(short));
            Console.WriteLine("Size of uint    : " + sizeof(uint));
            Console.WriteLine("Size of ushort  : " + sizeof(ushort));
            Console.WriteLine("Size of ulong   : " + sizeof(ulong));
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }
    }
}
