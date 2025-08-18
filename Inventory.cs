public class Inventory
{
    private List<Guitar> guitars;

    public Inventory()
    {
        guitars = new List<Guitar>();
    }

    public void AddGuitar(string serialNumber, double price, string builder, string model,string type, string backWood, string topWood)
    {
        Guitar guitar = new Guitar(serialNumber, price, builder, model, type, backWood, topWood);
        guitars.Add(guitar);
    }

    public Guitar GetGuitar(string serialNumber)
    {
        foreach (Guitar guitar in guitars)
        {
            if (guitar.SerialNumber == serialNumber)
            {
                return guitar; // Found the guitar with the matching serial number
            }
        }
        return null; // Return null if not found
    }

    public Guitar Search(Guitar searchGuitar)
    {
        foreach (Guitar guitar in guitars)
        {
            // Ignore serial number since that's unique
            // Ignore price since that's unique
            string builder = searchGuitar.Builder;
            if (!string.IsNullOrEmpty(builder) && builder != guitar.Builder)
                continue;

            string model = searchGuitar.Model;
            if (!string.IsNullOrEmpty(model) && model != guitar.Model)
                continue;

            string type = searchGuitar.Type;
            if (!string.IsNullOrEmpty(type) && type != guitar.Type)
                continue;

            string backWood = searchGuitar.BackWood;
            if (!string.IsNullOrEmpty(backWood) && backWood != guitar.BackWood)
                continue;

            string topWood = searchGuitar.TopWood;
            if (!string.IsNullOrEmpty(topWood) && topWood != guitar.TopWood)
                continue;

            // If we get here, the guitar matches all search criteria
            return guitar;
        }
        return null; // Return null if no match found
    }
}
