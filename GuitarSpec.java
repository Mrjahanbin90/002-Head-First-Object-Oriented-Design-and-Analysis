public class GuitarSpec {
    // Other properties
    private int numStrings;

    public GuitarSpec(Builder builder, String model, Type type,
                      Wood backWood, Wood topWood, int numStrings) {
        this.builder = builder;
        this.model = model;
        this.type = type;
        this.backWood = backWood;
        this.topWood = topWood;
        this.numStrings = numStrings;
    }

    // Other methods
    public int getNumStrings() {
        return numStrings;
    }
}

