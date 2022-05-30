using System;

namespace MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? strNumber;
            byte bytNumberMin = 1;
            ulong ulonNumberMax = ulong.MaxValue / 10;
            ulong ulonNumber;
            bool booError;
            
            while (1 == 1)
            {
                Console.WriteLine($"Enter an integer between {bytNumberMin} and {ulonNumberMax}. To exit, enter: Exit."); ;
                strNumber = Console.ReadLine();

                if (strNumber == "Exit" || strNumber == "exit")
                {
                    Console.WriteLine("Goodbye.");
                    break;
                }

                booError = ulong.TryParse(strNumber, out ulonNumber);

                if (booError == false || ulonNumber < bytNumberMin || ulonNumber > ulonNumberMax)
                {
                    Console.WriteLine("Incorrect data entered! Try again.");
                    Console.WriteLine("");
                    continue;
                }
                
                F_voiMultiplicationTable(ulonNumber);
                Console.WriteLine("");
            }
        }
        
        
        static void F_voiMultiplicationTable(ulong f_ulonNumber)
        {
            ulong ulonResult;
            for(uint int1=1; int1<=10; int1++)
            {
                ulonResult = f_ulonNumber * int1;
                Console.WriteLine($"{f_ulonNumber} x {int1} = {ulonResult}");
            }
        }
    }
}