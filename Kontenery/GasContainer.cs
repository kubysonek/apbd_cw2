namespace Kontenery;

public class GasContainer : Container, IHazardNotifier
{
    public double Pressure { get; }
    
    public GasContainer(double maxLoad, double height, double depth, double ownWeight, double pressure)
        : base("G", maxLoad, height, depth, ownWeight)
    {
        Pressure = pressure;
    }
    
    public override void UnloadCargo()
    {
        CargoWeight *= 0.05; // Zostawiamy 5% ładunku
    }
    
    public void NotifyHazard(string message)
    {
        Console.WriteLine($"[ALERT] {SerialNumber}: {message}");
    }
}