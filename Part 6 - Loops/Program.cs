using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_6___Loops
{
    internal class Program

    {
        static public void bMenu()
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
                    Console.Clear();
                    Blorb();
                    break;
                }
                else if (response == 3)
                {
                    Console.WriteLine("work in progress");
                    Console.WriteLine("press Enter to go back");
                    Console.ReadLine();
                    Console.Clear();
                    bMenu();

                }
                else
                {
                    Console.Clear();
                    
                    Console.WriteLine("not a number/out of selection range. try again");
                    bMenu();
                }
            }
        }
        static public void depositSec()
        {

        }
        static public void dithdrawSec()
        {

        }
        static public void billPaySec()
        {

        }
        static public void accBallUpSec()
        {

        }

        static public void Blorb()
        {
            // main ints
            int currentBal, action;
            // deposit ints
            int depoAmount;
            // withdrawl ints
            int withAmount;
            currentBal = (int)150.00;
            Console.WriteLine("select actions:");
            Console.WriteLine();
            Console.WriteLine("[1] deposit");
            Console.WriteLine("[2] withdrawal");
            Console.WriteLine("[3] bill payment");
            Console.WriteLine("[4] account balance");
                Int32.TryParse(Console.ReadLine(), out action);

            while (true)
            {
                
                    if (action == 1)
                    {
                        
                        Console.Clear();
                        Console.WriteLine("enter deposit amount");
                        currentBal = (int)(currentBal - 0.75);
                        

                        if (Int32.TryParse(Console.ReadLine(), out depoAmount))
                        {
                        currentBal = currentBal + depoAmount;
                            Console.WriteLine(currentBal);
                        Console.WriteLine(currentBal);
                        Console.WriteLine("Press enter to go back");
                        Console.ReadLine();
                        Console.Clear();
                        Blorb();
                        }
                    else
                    {
                        Console.WriteLine("try again");
                    }
                        
                        
                    }
                    else if (action == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("enter withdrawal amount");
                        currentBal = (int)(currentBal - 0.75);

                        if (Int32.TryParse(Console.ReadLine(), out withAmount) && withAmount <= currentBal)
                        {
                        currentBal = currentBal - withAmount;
                        Console.WriteLine("Done");
                        Console.WriteLine("Press enter to go back");
                        Console.ReadLine();
                        Console.Clear();
                        Blorb();

                        }
                        else
                        {
                        Console.WriteLine("try again");
                        }

                    }
                    else if (action == 3)
                    {
                    int act3answer;
                        Console.Clear();
                        Console.WriteLine("pay bill of 100$? \\ enter 1 for yes / 2 for no");
                        currentBal = (int)(currentBal - 0.75);
                    if (Int32.TryParse(Console.ReadLine(), out act3answer) && act3answer == 1 && currentBal >= 100)
                    {
                        Console.WriteLine("Bill paid");
                        Console.WriteLine("Press enter to go back");
                        Console.ReadLine();
                        Console.Clear();
                        Blorb();

                    }
                    else if (act3answer == 2)
                    {
                        Console.Clear();
                        Blorb();
                    }
                        

                    }
                    else if (action == 4)
                    {
                        Console.Clear();
                        currentBal = (int)(currentBal - 0.75);
                        Console.WriteLine(currentBal);
                    Console.WriteLine("Press enter to go back");
                    Console.ReadLine();
                    Console.Clear();
                    Blorb();
                }
                    else if (action == 0)
                    {
                        Console.Clear();
                        currentBal = (int)(currentBal - 0.75);
                        
                    }
                    else
                    {
                        Console.WriteLine("try again");
                        currentBal = (int)(currentBal - 0.75);
                    }
                
                if (action == 0)
                {
                    Console.Clear();
                    break;
                }
            }


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
            
            while (true)
            {
                Int32.TryParse(Console.ReadLine(), out numb);

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
            bMenu();

        }
    }
}
