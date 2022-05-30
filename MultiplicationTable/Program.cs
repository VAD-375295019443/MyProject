using System;

namespace MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? strNumber;
            byte bytNumberMin = 1;
            ulong uloNumberMax = ulong.MaxValue / 10;
            ulong ulonNumber;
            bool booError;
            
            while (1 == 1)
            {
                Console.WriteLine($"Введите целое число в диапазоне от {bytNumberMin} по {uloNumberMax}. Для выхода наберите: Exit."); ;
                strNumber = Console.ReadLine();

                if(strNumber == "Exit" || strNumber == "exit")
                {
                    Console.WriteLine("Goodbye.");
                    break;
                }

                booError = ulong.TryParse(strNumber, out ulonNumber);
                
                if(booError==false)
                {
                    Console.WriteLine("Не корректный ввод данных! Повторите попытку.");
                    Console.WriteLine("");
                    continue;
                }
                else
                {
                    if(ulonNumber<bytNumberMin || ulonNumber > uloNumberMax)
                    {
                        Console.WriteLine("Не корректный ввод данных! Повторите попытку.");
                        Console.WriteLine("");
                        continue;
                    }
                    else
                    {
                        F_voiMultiplicationTable(ulonNumber);
                        Console.WriteLine("");
                    }
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
            

            //Или так:
            /*
            while (1 == 1)
            {
                Console.WriteLine($"Введите целое число в диапазоне от {bytNumberMin} по {uloNumberMax}. Для выхода наберите: Exit."); ;
                strNumber = Console.ReadLine();

                if (strNumber == "Exit" || strNumber == "exit")
                {
                    Console.WriteLine("Goodbye.");
                    break;
                }
                //Первый шлюз пройден. (Мы не требуем выхода из консоли).

                booError = ulong.TryParse(strNumber, out ulonNumber);
                if (booError == false)
                {
                    Console.WriteLine("Не корректный ввод данных! Повторите попытку.");
                    Console.WriteLine("");
                    continue;
                }
                //Второй шлюз пройден. (Введенные данные успешно конвертированы).

                if (ulonNumber < bytNumberMin || ulonNumber > uloNumberMax)
                {
                    Console.WriteLine("Не корректный ввод данных! Повторите попытку.");
                    Console.WriteLine("");
                    continue;
                }
                //Третий шлюз пройден. (Конвертированные данные находятся в нужном диапазоне).
                //Т.е. ТОТАЛЬНЫЙ УСПЕХ при вводе данных!

                F_voiMultiplicationTable(ulonNumber);
                Console.WriteLine("");
            }

            static void F_voiMultiplicationTable(ulong f_ulonNumber)
            {
                ulong ulonResult;
                for (uint int1 = 1; int1 <= 10; int1++)
                {
                    ulonResult = f_ulonNumber * int1;
                    Console.WriteLine($"{f_ulonNumber} x {int1} = {ulonResult}");
                }
            }
            */
        }
    }
}