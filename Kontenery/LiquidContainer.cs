namespace Kontenery;

public class LiquidContainer : Container, IHazardNotifier{
    
    
    public bool IsHazardous { get; }
    
    public LiquidContainer(double maxLoad, double height, double depth, double ownWeight, bool isHazardous)
        : base("L", maxLoad, height, depth, ownWeight)
    {
        IsHazardous = isHazardous;
    }
    
    public override void LoadCargo(double addedCargoWeight)
    {
        double allowedLoad = IsHazardous ? MaxLoad * 0.5 : MaxLoad * 0.9;
        if (addedCargoWeight > allowedLoad)
        {
            NotifyHazard("Added cargo weight is exceeding this container's safe load!");
            if (addedCargoWeight > MaxLoad) 
            {
                throw new OverfillException("Added cargo weight is exceeding this container's safe load!");
            }
            
        }
        base.LoadCargo(addedCargoWeight);
    }
    
    public void NotifyHazard(string message)
    {
        Console.WriteLine($"[ALERT] {SerialNumber}: {message}");
    }
}