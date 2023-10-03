class Cargo
{
    public int Weight { get; }
    public string CargoType { get; }

    public Cargo(int Weight, string CargoType)
    {
        this.Weight = Weight;
        this.CargoType = CargoType;
    }
}
