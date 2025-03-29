namespace Kontenery;

public class RefrigeratedContainer : Container
{
    public Product StoredProduct { get; }
    public double Temperature { get; }

    public RefrigeratedContainer(double maxLoad, double height, double depth, double ownWeight, Product product, double temperature)
        : base("C", maxLoad, height, depth, ownWeight)
    {
        if (temperature < product.RequiredTemperature)
            throw new Exception($"Container's temperature is too low for: {product.Name}!");

        StoredProduct = product;
        Temperature = temperature;
    }
}