using Kontenery;

class Program {
    static void Main()
    {
        ContainerShip ship = new ContainerShip(50000, 10, 30);
        
        RefrigeratedContainer bananaContainer = new RefrigeratedContainer(10000, 200, 300, 1000, "Banany", 5);
        LiquidContainer fuelContainer = new LiquidContainer(8000, 200, 300, 1200, true);
        GasContainer heliumContainer = new GasContainer(5000, 180, 250, 900, 10);
        
        bananaContainer.LoadCargo(5000);
        fuelContainer.LoadCargo(4000);
        heliumContainer.LoadCargo(2000);
        
        ship.LoadContainer(bananaContainer);
        ship.LoadContainer(fuelContainer);
        ship.LoadContainer(heliumContainer);
        
        Console.WriteLine($"Total container weight: {ship.GetTotalWeight()} kg");
        
        ship.RemoveContainer(fuelContainer.SerialNumber);
        Console.WriteLine($"Łączna masa po usunięciu: {ship.GetTotalWeight()} kg");
    }
}



