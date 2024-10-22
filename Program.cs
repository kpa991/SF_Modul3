namespace Modul3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Name = "Pavel";
            byte MyAge = 25;
            bool HaveIApet = false;
            double ShoeSize = 42.2;

            Console.WriteLine("Меня зовут " + Name);
            Console.WriteLine("Мне " + MyAge + " Лет");
            Console.WriteLine("есть ли у меня питомцы? "+ HaveIApet);
            Console.WriteLine("Мой размер ноги " + ShoeSize);

            Console.ReadKey();

        }
    }
}
