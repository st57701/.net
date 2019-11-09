using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;
using ThirdNumber;

namespace CsharpSecondNumber
{
    class Program
    {
        static void Main(string[] args)

        {
            ReadFirst.ReadFirst read = new ReadFirst.ReadFirst();
            int firstNumber = read.ReadFirstN();
            Console.WriteLine("Pleas Type second Number : ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            ThirdN read2 = new ThirdN();
            int thirdNumber = read2.Metod();

            int result = firstNumber + secondNumber + thirdNumber;

            Console.WriteLine("Sum = " + result);

            Console.ReadLine();

        }
    }
}
