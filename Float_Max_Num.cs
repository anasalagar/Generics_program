using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericeUC2_floats
{
    class ChickFloatValue
    {
        public float first,second,third;

        public ChickFloatValue (float first ,float second , float third )
        {
            this.first = first;
            this.second = second;
            this.third = third;

        }
        public void MaxNum()
        {
            if (first.CompareTo(second)>0 && first.CompareTo(third)>0)
            {
                Console.WriteLine("The greater number is {0} " , first);
                Console.ReadLine();
            }
            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                Console.WriteLine("The greater number is {0}",second);
                Console.ReadLine();
            }
            else if (third.CompareTo(first)>0 &&  third.CompareTo(second)>0)
            {
                Console.WriteLine("The grater number is {0}", third);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("All numbers are same ");
                Console.ReadLine();
            }
        }

    }
}
