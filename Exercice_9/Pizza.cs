namespace Exercice_9
{
    public class Pizza
    {
        public double Price { get; } = 8.50;

        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();

        public void AddIngredient(int ingredient)
        {
            Ingredients.Add((Ingredient)ingredient);
        }

        public double TotalPrice()
        {
            return Price + (0.30 * Ingredients.Count);
        }
    }
}
