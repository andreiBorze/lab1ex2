using System;

namespace lab1ex2
{
    /*Scrieti un program care va calcula media aritmetica a trei numere citite de la tastatura*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Acest program va calcula media aritmetica a trei numere citite de la tastatura. \n");

            Console.WriteLine("Introduceti x:");
            var x = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti y:");
            var y = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti z:");
            var z = int.Parse(Console.ReadLine());

            Console.WriteLine("Media aritmetica: " +  (float)(x+y+z)/3);
        }
    }
}
