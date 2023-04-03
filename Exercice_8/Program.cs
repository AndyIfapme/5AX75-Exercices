namespace Exercice_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rectangle1 = new Rectangle(20, 10);
            ShowRectangle(rectangle1, nameof(rectangle1));

            var rectangle2 = new Rectangle(50,30);
            ShowRectangle(rectangle2, nameof(rectangle2));

            var rectangle3 = new Rectangle(250,180);
            ShowRectangle(rectangle3, nameof(rectangle3));
        }

        private static void ShowRectangle(Rectangle rectangle, string rectangleName)
        {
            Console.WriteLine($"La longueur du {rectangleName} est {rectangle.Longueur}");
            Console.WriteLine($"La largeur du {rectangleName} est {rectangle.Largeur}");
            Console.WriteLine($"L'air du {rectangleName} est : {rectangle.Air()}\n");
        }
    }
}