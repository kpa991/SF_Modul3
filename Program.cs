using System;

namespace Modul3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            byte age = (byte)int.Parse(Console.ReadLine());
            Console.Write("Enter your birthdate: ");
            string date = Console.ReadLine();
            DateTime birthdate = DateTime.Parse(date);
            Console.WriteLine("Your name is {0}, your age is {1} and your birthdate is " + birthdate.ToString("dd.MM.yyyy"), name, age);
            

        }
    }
    enum DaysOfWeek : byte
    {
        Monday =1,
        Tuesday =2,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
}
  

