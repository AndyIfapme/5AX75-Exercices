namespace Exercice_6
{
    internal class Program
    {
/*
 *  Pouvoir effectuer une soustraction.
 *  La division par 0 est impossible, il faut donc afficher un message d'erreur.
 *  Afficher un message d'erreur si l'utilisateur n'introduit pas un nombre entier.
 *
 *  On propose à l'utilisateur de recommancer tant qu'il n'introduit pas des valeurs entières
 */
        static void Main(string[] args)
        {
            string word;
            bool isParse;
            int a;

            Console.WriteLine("Application qui applique une soustraction");
            Console.WriteLine("-----------------------------------------\n");

            do
            {
                Console.Write("Veuillez introduire un nombre : ");

                word = Console.ReadLine()!;
                isParse = int.TryParse(word, out a);
                
                if (!isParse)
                {
                    Console.WriteLine("\tVous n'avez pas introduit un entier");
                }
            } while (!isParse);
        }
    }
}