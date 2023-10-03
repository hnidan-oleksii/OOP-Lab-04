class Engine
{
    public string Model { get; }
    public int Power { get; }
    public int _displacement = -1;
    public string _efficiency = "n/a";

    public Engine(string Model, int Power, int Displacement, string Efficiency)
    {
        this.Model = Model;
        this.Power = Power;
        this._displacement = Displacement;
        this._efficiency = Efficiency;
    }

    public Engine(string Model, int Power, int Displacement) : this(Model, Power, Displacement, "n/a")
    {
    }

    public Engine(string Model, int Power, string Efficiency) : this(Model, Power, -1, Efficiency)
    {
    }

    public Engine(string Model, int Power) : this(Model, Power, -1, "n/a")
    {
    }

    public int Displacement { get => _displacement; }
    public string Efficiency { get => _efficiency; }

    public override string ToString()
    {
        return 
            $"{Model}: " +
            $"\n    Power: {Power} " +
            $"\n    Displacement: {(Displacement == -1 ? "n/a" : Displacement)} " +
            $"\n    Efficiency: {(Efficiency)}";
    }
}