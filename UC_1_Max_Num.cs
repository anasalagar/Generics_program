using System.Text;
using System.Threading.Tasks;

namespace GenericsUC1
{
    class CheckMaxNumber
    {
        public int first, second, third;                                //create int  verible

        public CheckMaxNumber(int first ,int second ,int third)
        {
            this.first = first;
            this.second = second;
            this.third = third;
        }

        public void MaxNum()
        {                                                               //we comparing the first value to the second value grearter then zero .
            if (first.CompareTo(second)>0 && first.CompareTo(third)>0) 
                                                                        //first value comparing to third value greater then zero .
            {
                Console.WriteLine("The greater number is {0} ", first);     
                Console.ReadLine();
            }
            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                Console.WriteLine("The greater number is {0} ", second);
                Console.ReadLine();
            }
            else if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
            {
                Console.WriteLine("The greater number is {0} ", third);
                Console.ReadLine();
            }

            else  
            {
                Console.WriteLine("First , second and third number is same");   //all condition are fails then print else statment .
                Console.ReadLine();
            }
        }
    }
}
