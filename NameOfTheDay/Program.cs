using System;

namespace NameOfTheDay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? strDayNumber;

            while (1 == 1) //Исключительно для удобства.
            {
                Console.WriteLine("Введите номер дня недели (1 - понедельник, 2 - вторник и т.д.). Для выхода наберите: Exit.");
                strDayNumber = Console.ReadLine();
                strDayNumber = F_strNameOfTheDay(strDayNumber); //Использую туже переменную для уменьшения их количества (память экономлю:)).

                if (strDayNumber == "Exit" || strDayNumber == "exit")
                {
                    Console.WriteLine("Goodbye.");
                    break;
                }
                else
                {
                    Console.WriteLine(strDayNumber);
                    Console.WriteLine("");
                }
            }
        }
        

        static string F_strNameOfTheDay(string? f_strDayNumber)
        {
            switch (f_strDayNumber)
            {
                case "1":
                    return "Monday.";
                case "2":
                    return "Tuesday.";
                case "3":
                    return "Wednesday.";
                case "4":
                    return "Thursday.";
                case "5":
                    return "Friday.";
                case "6":
                    return "Saturday.";
                case "7":
                    return "Sunday.";
                case "Exit":
                    return "Exit";
                case "exit":
                    return "Exit";
            }
            return "Не корректный ввод данных! Повторите попытку.";
        }
    }
}