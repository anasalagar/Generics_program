using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericeUC2_floats
{
    class Program               //create class
    {
        static void Main(string[] args) //main method
        {
            float a;
            float b;
            float c;

            Console.Write("Enter first number : ");
            a = Convert.ToSingle(Console.ReadLine()); //convert to single

            Console.Write("Enter second number : ");
            b = Convert.ToSingle(Console.ReadLine());

            Console.Write("Enter third number : ");
            c = Convert.ToSingle(Console.ReadLine());

            ChickFloatValue Num = new ChickFloatValue(a, b, c);
            Num.MaxNum();


        }
    }
}
