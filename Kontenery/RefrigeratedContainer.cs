namespace Kontenery;

public class RefrigeratedContainer : Container {
    
    public string ProductType { get; }
    public double Temperature { get; }
    
    public RefrigeratedContainer(double maxLoad, double height, double depth, double ownWeight, string productType, double temperature)
        : base("C", maxLoad, height, depth, ownWeight)
    {
        ProductType = productType;
        Temperature = temperature;
    }
}