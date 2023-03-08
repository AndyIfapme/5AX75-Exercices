namespace Exercice_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Division entre deux nombres");
            
            Console.WriteLine("Veuillez introduire un nombre : ");
            var a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Veuillez introduire un nombre (!= 0): ");
            var b = Convert.ToInt32(Console.ReadLine());

            if (b == 0)
            {
                Console.WriteLine("Impossible d'effectuer une division par 0");
            }
            else
            {
                Console.WriteLine(a / b);
            }
        }
    }
}