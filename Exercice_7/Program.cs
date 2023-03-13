namespace Exercice_7
{
    internal class Program
    {
/*
 *  Sur base de l'exercice précédent, développer une calculatrice avec les opérations de base.
 * (addition, soustraction division,  multiplication.
 *
 *  Au lancement de l'application, un menu doit s'afficher et l'utilisateur doit choisir quel type
 *  d'opération il doit effectuer.
 *
 *  Rappel : La division par 0 est impossible, il faut donc afficher un message d'erreur.
 *  Afficher un message d'erreur si l'utilisateur n'introduit pas un nombre entier.
 *
 *  On propose à l'utilisateur de recommancer tant qu'il n'introduit pas des valeurs entières
 */

        static void Main(string[] args)
        {
            //Exemple pour faire l'exercice :4
            ColorEnum color;
            string word;
            bool isParseOk;
           
            Console.Write("Veuillez introduire une couleur : ");
            word = Console.ReadLine()!;

            isParseOk = Enum.TryParse(word, out color);

            if (isParseOk == false || (int) color < 0 || (int) color > 3)
            {
                Console.WriteLine("Vous n'avez pas introduit une couleur valide !");
            }
            else
            {
                switch (color)
                {
                    case ColorEnum.Red:
                    {
                        Console.WriteLine("La couleur est rouge");
                        break;
                    }
                    case ColorEnum.Green:
                        Console.WriteLine("La couleur est verte");
                        break;
                    case ColorEnum.Blue:
                        Console.WriteLine("La couleur est bleu");
                        break;
                    case ColorEnum.Black:
                        Console.WriteLine("La couleur est noir");

                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }
    }
}