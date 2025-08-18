public class FindGuitarTester
{
    public static void Main(string[] args)
    {
        // Set up Rick's guitar inventory
        Inventory inventory = new Inventory();
        InitializeInventory(inventory);

        // Erin comes in and tells Rick what she likes
        Guitar whatErinLikes = new Guitar("", 0, "fender", "Stratocaster", "electric", "Alder", "Alder");
        Guitar guitar = inventory.Search(whatErinLikes);

        if (guitar != null)
        {
            Console.WriteLine($"Erin, you might like this {guitar.Builder} {guitar.Model} " +
                              $"guitar, made of {guitar.BackWood} back and sides, {guitar.TopWood} top. \n" +
                              $"You can have it for only ${guitar.Price}!");
        }
        else
        {
            Console.WriteLine("Sorry, Erin, we have nothing for you.");
        }
    }

    private static void InitializeInventory(Inventory inventory)
    {
        // Add guitars to the inventory....
    }
}
