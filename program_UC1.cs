using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsUC1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;                                          //create int 
            int b;
            int c;
            Console.WriteLine("Enter the first number : "); //take input to uses. 
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number : ");
             b= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the third number : ");
            c = Convert.ToInt32(Console.ReadLine());

            CheckMaxNumber num = new CheckMaxNumber(a, b, c); //num is verible .
            num.MaxNum();

        }
    }
}
