namespace Kontenery;

public class ContainerShip {
    
    public string Name { get; }
    public List<Container> Containers { get; } = new List<Container>();
    public double MaxWeight { get; } // in tons
    public int MaxContainers { get; }
    public double Speed { get; } // in knots
    
    public ContainerShip(string name, double maxWeight, int maxContainers, double speed)
    {
        Name = name;
        MaxWeight = maxWeight;
        MaxContainers = maxContainers;
        Speed = speed;
    }
    
    public void LoadContainerOnShip(Container container)
    {
        if (Containers.Count >= MaxContainers)
            throw new OverfillException("Added container is exceeding this ship's max container count!");
        if (GetTotalWeight() + container.OwnWeight + container.CargoWeight > MaxWeight * 1000) // * 1000 bsc it's in tons
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
    
    
    public void TransferContainer(ContainerShip targetShip, string serialNumber)
    {
        Container container = Containers.Find(c => c.SerialNumber == serialNumber);
        if (container == null) {
            throw new Exception("Container not found!");
        }
        RemoveContainerFromShip(serialNumber);
        targetShip.LoadContainerOnShip(container);
    }
    
    public double GetTotalWeight()
    {
        double total = 0;
        foreach (var c in Containers)
            total += c.OwnWeight + c.CargoWeight;
        return total;
    }
    
    
    public void PrintShipInfo()
    {
        Console.WriteLine($"{Name}: Max weight: {MaxWeight}kg, Max conteiners: {MaxContainers}, Speed: {Speed} knots");
        Console.WriteLine("Containers that are already on board:");
        foreach (var container in Containers)
        {
            Console.WriteLine(container);
        }
        Console.WriteLine();
    }
    
}