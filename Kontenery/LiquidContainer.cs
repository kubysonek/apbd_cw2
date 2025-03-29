namespace Kontenery;

public class LiquidContainer : Container, IHazardNotifier{
    
    
    public bool IsHazardous { get; }
    
    public LiquidContainer(double maxLoad, double height, double depth, double ownWeight, bool isHazardous)
        : base("L", maxLoad, height, depth, ownWeight)
    {
        IsHazardous = isHazardous;
    }
    
    public override void LoadCargo(double weight)
    {
        double allowedLoad = IsHazardous ? MaxLoad * 0.5 : MaxLoad * 0.9;
        if (weight > allowedLoad)
        {
            NotifyHazard("Próba załadowania niebezpiecznej ilości do kontenera!");
            throw new OverfillException("Przekroczono bezpieczną ładowność kontenera!");
        }
        base.LoadCargo(weight);
    }
    
    public void NotifyHazard(string message)
    {
        Console.WriteLine($"[ALERT] {SerialNumber}: {message}");
    }
}