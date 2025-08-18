public class FindGuitarTester {
    public static void main(String[] args) {
        // Set up Rick's guitar inventory
        Inventory inventory = new Inventory();
        initializeInventory(inventory);

        // Erin comes in and tells Rick what she likes
        Guitar whatErinLikes = new Guitar("", 0, "fender", "Stratocaster", "electric", "Alder", "Alder");
        Guitar guitar = inventory.search(whatErinLikes);

        if (guitar != null) {
            System.out.println("Erin, you might like this " + guitar.getBuilder() + " " + guitar.getModel() +
                    " guitar, made of " + guitar.getBackWood() + " back and sides, " + guitar.getTopWood() + " top. \n" +
                    "You can have it for only $" + guitar.getPrice() + "!");
        } else {
            System.out.println("Sorry, Erin, we have nothing for you.");
        }
    }

    private static void initializeInventory(Inventory inventory) {
        // Add guitars to the inventory....
    }
}
