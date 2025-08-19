public class Inventory
{
    // variables, constructor, and other methods

    public List<Guitar> Search(GuitarSpec searchSpec)
    {
        List<Guitar> matchingGuitars = new List<Guitar>();
        foreach (Guitar guitar in guitars)
        {
            GuitarSpec guitarSpec = guitar.GetSpec();

            if (!searchSpec.Builder.Equals(guitarSpec.Builder))
                continue;

            if (model != null && !string.IsNullOrEmpty(model) &&
                !model.Equals(searchSpec.Model, StringComparison.OrdinalIgnoreCase))
                continue;

            if (!searchSpec.Type.Equals(guitarSpec.Type))
                continue;

            if (!searchSpec.BackWood.Equals(guitarSpec.BackWood))
                continue;

            if (!searchSpec.TopWood.Equals(guitarSpec.TopWood))
                continue;

            matchingGuitars.Add(guitar);
        }
        return matchingGuitars;
    }
}
