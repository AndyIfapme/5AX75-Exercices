namespace Exercice_8
{
    public class Rectangle
    {
        public int Longueur { get; init; }
        public int Largeur { get; init; }

        public Rectangle(int longueur, int largeur)
        {
            Longueur = longueur;
            Longueur = largeur;
        }

        public int Air() => Longueur * Largeur;

        public override string ToString()
        {
            int air = Air();
            return @$"La longueur du rectangle est {Longueur}
La largeur du rectangle est {Largeur}
L'air du rectangle est : {air}
            ";
        }
    }
}
