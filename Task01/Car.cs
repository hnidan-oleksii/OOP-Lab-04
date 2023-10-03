class Car
{
    public string Model { get; }
    public Engine CarEngine { get; }
    public Cargo CarCargo { get; }
    public Tire[] CarTires { get; }

    public Car(string Model, 
        int EngineSpeed, int EnginePower,
        int CargoWeight, string CargoType,
        double Tire1Pressure, int Tire1Age,
        double Tire2Pressure, int Tire2Age,
        double Tire3Pressure, int Tire3Age,
        double Tire4Pressure, int Tire4Age)
    {
        this.Model = Model;
        this.CarEngine = new Engine(EngineSpeed, EnginePower);
        this.CarCargo = new Cargo(CargoWeight, CargoType);
        this.CarTires = new Tire[4]
        {
            new Tire(Tire1Pressure, Tire1Age),
            new Tire(Tire2Pressure, Tire2Age),
            new Tire(Tire3Pressure, Tire3Age),
            new Tire(Tire4Pressure, Tire4Age),
        };
    }
}
