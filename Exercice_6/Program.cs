namespace Exercice_6
{
    internal class Program
    {
/*
 *  Pouvoir effectuer une division.
 *  La division par 0 est impossible, il faut donc afficher un message d'erreur.
 *  Afficher un message d'erreur si l'utilisateur n'introduit pas un nombre entier.
 *
 *  On propose à l'utilisateur de recommancer tant qu'il n'introduit pas des valeurs entières
 */
        static void Main(string[] args)
        {
            string word;
            bool isParseOk;
            int a, b;

            Console.WriteLine("Application qui applique une division");
            Console.WriteLine("-------------------------------------\n");

            do
            {
                Console.Write("Veuillez introduire un nombre : ");
                word = Console.ReadLine()!;
                isParseOk = int.TryParse(word, out a);

                if (isParseOk == false)
                {
                    Console.WriteLine("\tVous n'avez pas introduit un nombre !");
                }
            } while (isParseOk == false);

            do
            {
                Console.Write("Veuillez introduire le diviseur : ");
                word = Console.ReadLine()!;
                isParseOk = int.TryParse(word, out b);

                if (isParseOk == false)
                {
                    Console.WriteLine("\tVous n'avez pas introduit un nombre !");
                }
                else if (b == 0)
                {
                    Console.WriteLine("\tVous n'avez pas effectuer une division par 0");
                }

            } while (isParseOk == false || b == 0);

            Console.WriteLine($"Le résultat de la division est : {a / b}");
        }
    }
}