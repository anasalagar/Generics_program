using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_UC_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string a, b, c;

            Console.WriteLine("Enter the first string : ");
            a = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter the second string : ");
            b = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter the third string : ");
            c = Convert.ToString(Console.ReadLine());

            StringMax_UC3 d = new StringMax_UC3(a, b, c);
            d.FindMax();

        }
    }
}
