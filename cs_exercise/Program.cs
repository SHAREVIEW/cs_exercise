using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_exercise
{
    class Program
    {


        //光维面试题：存取钱步骤
        static void Main(string[] args)
        {
            double integerNumber;            
            double temp,balance = 10000;
            Console.WriteLine("Balance is {0}.",balance);
            Console.WriteLine("Enter a number:\n1: Save money;\n2: Take money;\n3: Quit.", balance);
            integerNumber = Convert.ToDouble(Console.ReadLine());
            switch (integerNumber)
            {
                case 1:
                    Console.WriteLine("Save money:");
                    temp = Convert.ToDouble(Console.ReadLine());
                    balance += temp;
                    Console.WriteLine("Balance is {0}.", balance);
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Take money:");
                    temp = Convert.ToDouble(Console.ReadLine());
                    balance -= temp;
                    Console.WriteLine("Balance is {0}.", balance);
                    Console.ReadLine();
                    break;
                case 3:
                    break;
                default:
                    break;








            }






        }
    }
}
