public class Inventory {
    // variables, constructor, and other methods

    public List search(GuitarSpec searchSpec) {
        List matchingGuitars = new LinkedList();
        for (Iterator i = guitars.iterator(); i.hasNext(); ) {
            Guitar guitar = (Guitar) i.next();
            GuitarSpec guitarSpec = guitar.getSpec();

            if (!searchSpec.getBuilder().equals(guitarSpec.getBuilder()))
                continue;

            if ((model != null) && (!model.equals("")) &&
                (!model.equalsIgnoreCase(searchSpec.getModel())))
                continue;

            if (!searchSpec.getType().equals(guitarSpec.getType()))
                continue;

            if (!searchSpec.getBackWood().equals(guitarSpec.getBackWood()))
                continue;

            if (!searchSpec.getTopWood().equals(guitarSpec.getTopWood()))
                continue;
            matchingGuitars.add(guitar);
        }
        return matchingGuitars;
    }
}
