namespace Kontenery;

public class ContainerShip
{
    public List<Container> Containers { get; } = new List<Container>();
    public double MaxWeight { get; }
    public int MaxContainers { get; }
    public double Speed { get; }
    
    public ContainerShip(double maxWeight, int maxContainers, double speed)
    {
        MaxWeight = maxWeight;
        MaxContainers = maxContainers;
        Speed = speed;
    }
    
    public void LoadContainer(Container container)
    {
        if (Containers.Count >= MaxContainers || GetTotalWeight() + container.OwnWeight + container.CargoWeight > MaxWeight)
            throw new Exception("Przekroczono limity załadunku!");
        
        Containers.Add(container);
    }
    
    public void RemoveContainer(string serialNumber)
    {
        Containers.RemoveAll(c => c.SerialNumber == serialNumber);
    }
    
    public double GetTotalWeight()
    {
        double total = 0;
        foreach (var c in Containers)
            total += c.OwnWeight + c.CargoWeight;
        return total;
    }
}