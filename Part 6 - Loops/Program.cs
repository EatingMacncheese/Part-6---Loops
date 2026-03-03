using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_6___Loops
{
    internal class Program

    {
        static public void Blorb()
        {
            int deposit, withdrawal, billPay, accBalUp, currentBal;

            Console.WriteLine("select actions:");
            Console.WriteLine();
            Console.WriteLine("[1] deposit");
            Console.WriteLine("[2] withdrawal");
            Console.WriteLine("[3] bill payment");
            Console.WriteLine("[4] account balance");
        }
        static public void number()
        {
            int minNum;
            int maxNum;
            int numb;


            Console.WriteLine("enter a minimum number");
            Int32.TryParse(Console.ReadLine(), out minNum);

            Console.WriteLine("enter a maximum number");
            Int32.TryParse(Console.ReadLine(), out maxNum);

            Console.WriteLine($"enter a number between {minNum} and {maxNum}");
            Int32.TryParse(Console.ReadLine(), out numb);
            while (true)
            {
                if (numb > minNum && numb < maxNum)
                {
                    Console.WriteLine("correct");
                    break;
                }
                else
                {
                    Console.WriteLine("no");
                }
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            Console.Clear();
        }
        static public void dice()
        {

        }
        static void Main(string[] args)
        {
            int response;
            Console.WriteLine("type a number for the following program:");
            Console.WriteLine();
            Console.WriteLine("[1] Numbers");
            Console.WriteLine("[2] Blorb ATM (W.I.P)");
            Console.WriteLine("[3] Dice Game (W.I.P)");
            Int32.TryParse(Console.ReadLine(), out response);
            while (true)
            {

            
                if (response == 1)
                {
                    Console.Clear();
                    number();
                    break;
                }
                else if (response == 2)
                {
                    Console.WriteLine("work in progress");
                    
                }
                else if (response == 3)
                {
                    Console.WriteLine("work in progress");
                    
                }
                else
                {
                    Console.WriteLine("not a number/out of selection range. try again");
                }
            }

        }
    }
}
