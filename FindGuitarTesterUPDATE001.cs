using System;
using System.Collections.Generic;

public class FindGuitarTester
{
    public static void Main(string[] args)
    {
        // Set up Rick's guitar inventory
        Inventory inventory = new Inventory();
        InitializeInventory(inventory);

        GuitarSpec whatErinLikes =
            new GuitarSpec(Builder.Fender, "Stratocastor", Type.Electric, Wood.Alder, Wood.Alder);

        List<Guitar> matchingGuitars = inventory.Search(whatErinLikes);

        if (matchingGuitars.Count > 0)
        {
            Console.WriteLine("Erin, you might like these guitars:");
            foreach (var guitar in matchingGuitars)
            {
                GuitarSpec spec = guitar.GetSpec();
                Console.WriteLine($"  We have a {spec.Builder} {spec.Model} {spec.Type} guitar:\n" +
                                  $"     {spec.BackWood} back and sides,\n" +
                                  $"     {spec.TopWood} top.\n" +
                                  $"  You can have it for only ${guitar.GetPrice()}!\n ----");
            }
        }
        else
        {
            Console.WriteLine("Sorry, Erin, we have nothing for you.");
        }
    }

    private static void InitializeInventory(Inventory inventory)
    {
        // Add guitars to the inventory...
    }
}
