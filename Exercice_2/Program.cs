namespace Exercice_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Valeur 1 : ");
            var a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Valeur 2 : ");
            var b = Convert.ToInt32(Console.ReadLine());

            (a, b) = (b, a);

            Console.WriteLine($"A : {a} et\nB :{b}");
        }   
    }
}