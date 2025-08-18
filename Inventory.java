public class Inventory {
    private List guitars;

    public Inventory() {
        guitars = new LinkedList();
        // Remember, we've stripped out the import statements to save some space.
    }

    public void addGuitar(String serialNumber, double price, String builder, String model, 
                           String type, String backWood, String topWood) {
        Guitar guitar = new Guitar(serialNumber, price, builder, model, type, backWood, topWood);
        guitars.add(guitar);
    }

    public Guitar getGuitar(String serialNumber) {
        for (Iterator i = guitars.iterator(); i.hasNext(); ) {
            Guitar guitar = (Guitar) i.next();
            if (guitar.getSerialNumber().equals(serialNumber)) {
                return guitar;  // Found the guitar with the matching serial number
            }
        }
        return null;  // Return null if not found
    }

    public Guitar search(Guitar searchGuitar) {
        for (Iterator i = guitars.iterator(); i.hasNext(); ) {
            Guitar guitar = (Guitar) i.next();
            
            // Ignore serial number since that's unique
            // Ignore price since that's unique
            String builder = searchGuitar.getBuilder();
            if ((builder != null) && (!builder.equals("")) && (!builder.equals(guitar.getBuilder())))
                continue;
                
            String model = searchGuitar.getModel();
            if ((model != null) && (!model.equals("")) && (!model.equals(guitar.getModel())))
                continue;
                
            String type = searchGuitar.getType();
            if ((type != null) && (!type.equals("")) && (!type.equals(guitar.getType())))
                continue;
                
            String backWood = searchGuitar.getBackWood();
            if ((backWood != null) && (!backWood.equals("")) && (!backWood.equals(guitar.getBackWood())))
                continue;
                
            String topWood = searchGuitar.getTopWood();
            if ((topWood != null) && (!topWood.equals("")) && (!topWood.equals(guitar.getTopWood())))
                continue;

            // If we get here, the guitar matches all search criteria
            return guitar;  
        }
        return null;  // Return null if no match found
    }
}
