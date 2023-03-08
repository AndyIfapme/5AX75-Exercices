namespace Exercice_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Valeur 1 (0 et 10): ");
            var a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Valeur 2 (0 et 10): ");
            var b = Convert.ToInt32(Console.ReadLine());

            if (a >= 0 && b >= 0 && a <= 10 && b <= 10)
            {
                Console.WriteLine(a + b);
            }
            else
            {
                Console.WriteLine("Vous ne pouvez calculer que les chiffres entre 0 et 10");
            }

        }
    }
}