namespace Theory_Nullable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 0;
            int? b = 11;

            if (b.HasValue && b.Value > 10)
            {
                Console.WriteLine($"Votre valeur est {b.Value}");

            }
        }
    }
}