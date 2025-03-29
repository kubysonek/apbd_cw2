namespace Kontenery;

public class ContainerShip
{
    public List<Container> Containers { get; } = new List<Container>();
    public double MaxWeight { get; } // in tons
    public int MaxContainers { get; }
    public double Speed { get; } // in knots
    
    public ContainerShip(double maxWeight, int maxContainers, double speed)
    {
        MaxWeight = maxWeight;
        MaxContainers = maxContainers;
        Speed = speed;
    }
    
    public void LoadContainerOnShip(Container container)
    {
        if (Containers.Count >= MaxContainers)
            throw new OverfillException("Added container is exceeding this ship's max container count!");
        if (GetTotalWeight() + container.OwnWeight + container.CargoWeight > MaxWeight / 1000) // /1000 bsc it's in tons
            throw new OverfillException("Added cargo weight is exceeding this ship's max load!");
        
        Containers.Add(container);
    }
    
    public void RemoveContainerFromShip(string serialNumber)
    {
        Containers.RemoveAll(c => c.SerialNumber == serialNumber);
    }

    public void ReplaceContainerWithAnotherOne(string serialNumberOfRemovedContainer, Container container) {
        RemoveContainerFromShip(serialNumberOfRemovedContainer);
        LoadContainerOnShip(container);
    }
    
    public double GetTotalWeight()
    {
        double total = 0;
        foreach (var c in Containers)
            total += c.OwnWeight + c.CargoWeight;
        return total;
    }
}