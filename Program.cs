namespace Modul3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string MyName;
            MyName = "Pavel";
            Console.WriteLine(MyName);
            Console.WriteLine("Привет, \n мир");
            Console.WriteLine("\t Привет Мир");
            Console.WriteLine("\t Мне 27 лет");
            Console.WriteLine("\t My name is \n {0}", MyName);
            Console.WriteLine("\u0040");
            Console.WriteLine("\x23");
            Console.ReadKey();

        }
    }
}
