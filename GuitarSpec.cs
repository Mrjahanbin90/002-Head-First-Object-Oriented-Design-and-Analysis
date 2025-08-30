public class GuitarSpec
{
    // سایر خصوصیات
    private int numStrings;

    public Builder Builder { get; }
    public string Model { get; }
    public Type Type { get; }
    public Wood BackWood { get; }
    public Wood TopWood { get; }

    public GuitarSpec(Builder builder, string model, Type type,
                      Wood backWood, Wood topWood, int numStrings)
    {
        Builder = builder;
        Model = model;
        Type = type;
        BackWood = backWood;
        TopWood = topWood;
        this.numStrings = numStrings;
    }

    // متد مشابه getNumStrings جاوا
    public int GetNumStrings()
    {
        return numStrings;
    }
}
