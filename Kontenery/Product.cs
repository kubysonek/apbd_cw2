namespace Kontenery;

public class Product
{
    public string Name { get; }
    public double RequiredTemperature { get; }

    public Product(string name, double requiredTemperature)
    {
        Name = name;
        RequiredTemperature = requiredTemperature;
    }
}
