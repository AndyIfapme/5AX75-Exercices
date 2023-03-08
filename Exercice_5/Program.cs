namespace Exercice_5
{
/*
 *  Pouvoir effectuer une soustraction.
 *  La division par 0 est impossible, il faut donc afficher un message d'erreur.
 *  Afficher un message d'erreur si l'utilisateur n'introduit pas un nombre entier.
 */
    internal class Program
    {
        static void Main(string[] args)
        { 
            bool isParse;
            string word;
            int a, diviseur;

            Console.WriteLine("Application qui applique une soustraction");
            Console.WriteLine("-----------------------------------------\n");

            Console.Write("Veuillez introduire un nombre : ");

            word = Console.ReadLine()!;
            isParse = int.TryParse(word, out a);

            if (isParse)
            {
                Console.Write("Veuillez introduire le diviseur : ");
                word = Console.ReadLine()!;
                isParse = int.TryParse(word, out diviseur);
                
                if (isParse)
                {
                    if (diviseur == 0)
                    {
                        Console.WriteLine("\tVous ne pouvez pas diviser par 0 !");
                    }
                    else
                    {
                        Console.WriteLine($"Votre résultat est {a / diviseur}");
                    }
                }
                else
                {
                    Console.WriteLine("\tVous n'avez introduit un nombre !");
                }
            }
            else
            {
                Console.WriteLine("\tVous n'avez introduit un nombre !");
            }
        }
    }
}