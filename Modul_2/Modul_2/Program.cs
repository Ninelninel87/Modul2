using System;

namespace Modul_2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string fullName = "Иванов Иван";
            byte age = 20;
            string email = "ivanovivan@gmail.com";
            double scoreProgramming = 4.4;
            double scoreMath = 3.2;
            double scorePhysics = 3.7;
            double scoreSum = scoreProgramming + scoreMath + scorePhysics;
            double scoreGpa = scoreSum / 3;
            
            Console.WriteLine($"{"ФИО:",20} {fullName,20}");
            Console.WriteLine($"{"Возраст:",20} {age,20}");
            Console.WriteLine($"{"E-mail:",20} {email,20}");
            Console.WriteLine($"{"Программирование:",20} {scoreProgramming,20}");
            Console.WriteLine($"{"Математика:",20} {scoreMath,20}");
            Console.WriteLine($"{"Физика:",20} {scorePhysics,20}");
            Console.WriteLine($"{"Сумма балов:",20} {scoreSum,20}");
            Console.WriteLine($"{"Средний балл:",20} {scoreGpa.ToString("#.##"),20}");

            Console.ReadKey();


            
        }
    }
}
