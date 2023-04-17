using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1Ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x;
            double y;
            double z;

            Console.Write("Insira o valor de x: ");
            x = double.Parse(Console.ReadLine());

            Console.Write("Insira o valor de y: ");
            y = double.Parse(Console.ReadLine());

            z = Math.Pow(x, y);

        

            Console.WriteLine("A Quantia de {0} elevado a {1} é {2}.", x,y,z);
        }
    }
}
