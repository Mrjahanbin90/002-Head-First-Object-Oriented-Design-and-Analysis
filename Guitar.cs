public class Guitar
{
    // Properties corresponding to the Java class fields
    private string serialNumber;
    private string builder;
    private string model;
    private string type;
    private string backWood;
    private string topWood;
    private double price;

    // Constructor
    public Guitar(string serialNumber, double price, string builder, string model,
                  string type, string backWood, string topWood)
    {
        this.serialNumber = serialNumber;
        this.price = price;
        this.builder = builder;
        this.model = model;
        this.type = type;
        this.backWood = backWood;
        this.topWood = topWood;
    }

    // Getters and Setters
    public string SerialNumber
    {
        get { return serialNumber; }
    }

    public double Price
    {
        get { return price; }
        set { price = value; }
    }

    public string Builder
    {
        get { return builder; }
    }

    public string Model
    {
        get { return model; }
    }

    public string Type
    {
        get { return type; }
    }

    public string BackWood
    {
        get { return backWood; }
    }

    public string TopWood
    {
        get { return topWood; }
    }
}
