using Kontenery;

class Program {
    static void Main()
    {
        ContainerShip ship = new ContainerShip(50000, 10, 30);
        
        RefrigeratedContainer bananaContainer = new RefrigeratedContainer(10000, 200, 300, 1000, "Banany", 5);
        LiquidContainer fuelContainer = new LiquidContainer(8000, 200, 300, 1200, true);
        GasContainer heliumContainer = new GasContainer(5000, 180, 250, 900, 10);
        
        bananaContainer.LoadCargo(5000);
        fuelContainer.LoadCargo(3000);
        heliumContainer.LoadCargo(2000);
        
        ship.LoadContainerOnShip(bananaContainer);
        ship.LoadContainerOnShip(fuelContainer);
        ship.LoadContainerOnShip(heliumContainer);
        
        Console.WriteLine($"Total container weight: {ship.GetTotalWeight()} kg");
        
        ship.RemoveContainerFromShip(fuelContainer.SerialNumber);
        Console.WriteLine($"Total container weight: {ship.GetTotalWeight()} kg");
    }
}



