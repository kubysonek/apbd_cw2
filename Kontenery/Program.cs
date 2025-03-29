using Kontenery;

class Program
{
    static void Main()
    {
        Product bananas = new Product("Banana", 13.3);
        RefrigeratedContainer bananaContainer = new RefrigeratedContainer(10000, 200, 300, 1000, bananas, 15);
        LiquidContainer fuelContainer = new LiquidContainer(8000, 200, 300, 1200, true);
        GasContainer heliumContainer = new GasContainer(5000, 180, 250, 900, 10);
        
        bananaContainer.LoadCargo(5000);
        fuelContainer.LoadCargo(4000);
        heliumContainer.LoadCargo(2000);
        
        ContainerShip ship1 = new ContainerShip("Titanic",50, 10, 30);
        ContainerShip ship2 = new ContainerShip("Black Pearl",30, 5, 50);
        ship1.LoadContainerOnShip(bananaContainer);
        ship1.LoadContainerOnShip(fuelContainer);
        ship1.LoadContainerOnShip(heliumContainer);
        
        ship1.PrintShipInfo();
        
        ship1.TransferContainer(ship2, bananaContainer.SerialNumber);
        
        
        Console.WriteLine("---------------AFTER CONTAINER TRANSFER--------------------");
        ship1.PrintShipInfo();
        ship2.PrintShipInfo();
    }
}



