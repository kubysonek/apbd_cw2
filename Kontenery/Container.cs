namespace Kontenery;

public class Container {

    public int CargoMass { get; set; }
    public int Height { get; set; }
    public int Weight { get; set; }
    public int Depth { get; set; }
    public string? SerialNumber { get; set; }
    public int MaxLoad { get; set; }

    
    public Container() {}
    public Container(int maxLoad) {
        MaxLoad = maxLoad;
    }


    public void UnloadCargo() {

    }

    public void LoadCargo(int addedCargoWeight) {

        if (addedCargoWeight > MaxLoad) {
            throw new OverfillException("added cargo weight is exceeding this container's max load");
        }

    }

}