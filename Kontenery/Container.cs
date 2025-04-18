﻿namespace Kontenery;

public class Container {

    private static int idCounter = 1;
    public string SerialNumber { get; }
    public double CargoWeight { get; protected set; }
    public double MaxLoad { get; }
    public double Height { get; }
    public double Depth { get; }
    public double OwnWeight { get; }

    
    protected Container(string type, double maxLoad, double height, double depth, double ownWeight)
    {
        SerialNumber = $"KON-{type}-{idCounter++}";
        MaxLoad = maxLoad;
        Height = height;
        Depth = depth;
        OwnWeight = ownWeight;
    }


    public virtual void UnloadCargo() {
        CargoWeight = 0;
    }

    public virtual void LoadCargo(double addedCargoWeight) {

        if (addedCargoWeight > MaxLoad) {
            throw new OverfillException("Added cargo weight is exceeding this container's max load!");
        }
        CargoWeight += addedCargoWeight;
    }
    
    public override string ToString()
    {
        return $"{SerialNumber}: Own weigh: {OwnWeight} kg, Cargo: {CargoWeight}/{MaxLoad} kg, Size: {Height}x{Depth} cm";
    }

}