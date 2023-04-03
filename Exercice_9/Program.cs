namespace Exercice_9
{
    internal class Program
    {
        /*
         * Concevoir une application qui va prendre la commande d'une pizza de l'utilisateur.
         * L'utilisateur va pouvoir mettre des ingrédients sur la pizza
         *
         * La pizza à un prix de base (que vous définir)
         * Chaque ingrédient est un cout suplémentaire de 0.30€
         *
         * On ne peut pas introduire plus de 10 ingrédients et l'utilisateur ne peut introduire de doublon.
         *
         * Pour cette exercice, un incrédient est simplement un string.
         * Il faut utiliser l'orienté objet.
         */

        static void Main(string[] args)
        {
            const int maxIncredients = 5;

            int ingredientCount = Enum.GetValues(typeof(Ingredient)).Cast<Ingredient>().Count();
            int newIngredient = -1;

            Pizza pizza = new Pizza();

            Console.WriteLine("Welcome to Pizza 2000 !");
            Console.WriteLine("-----------------------");

            Console.WriteLine("Veuillez choisir les ingrédients que vous souhaitez suivant la liste ci-dessous :");
           
            ShowIngredients();

            do
            {
                Console.Write("Veuillez introduire votre ingrédient : ");
                bool isParseOk = int.TryParse(Console.ReadLine()!, out newIngredient);
                if (isParseOk == false)
                {
                    Console.WriteLine("\tVous n'avez introduit un entier");
                }
                else 
                {
                    if (newIngredient < 0 || newIngredient >= ingredientCount)
                    {
                        Console.WriteLine("\tVotre ingrédient n'existe pas.");
                    }
                    else
                    {
                        pizza.AddIngredient(newIngredient);
                    }
                }

            } while (pizza.Ingredients.Count < maxIncredients);

            Console.WriteLine($"Le prix total de votre pizza est de {pizza.TotalPrice()} €");
        }

        private static void ShowIngredients()
        {
            var ingredients = Enum.GetValues(typeof(Ingredient)).Cast<Ingredient>().ToList();
            for (int i = 0; i < ingredients.Count; i++)
            {
                Console.WriteLine($"{i}) {ingredients[i]}");
            };
        }
    }
}