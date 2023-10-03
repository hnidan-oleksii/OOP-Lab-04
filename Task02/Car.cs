using System.Drawing;

class Car
{
    public string Model { get; }
    public Engine CarEngine { get; }
    private int _weight = -1;
    private string _color = "n/a";
    

    public Car(string Model, Engine CarEngine, int Weight, string Color)
    {
        this.Model = Model;
        this.CarEngine = CarEngine;
        this._weight= Weight;
        this._color = Color;
    }

    public Car(string Model, Engine CarEngine, int Weight) : this(Model, CarEngine, Weight, "")
    { 
    }

    public Car(string Model, Engine CarEngine, string Color) : this(Model, CarEngine, -1, Color)
    {
    }

    public Car(string Model, Engine CarEngine) : this(Model, CarEngine, -1, "")
    {
    }

    public int Weight { get => _weight; }
    public string Color { get => _color; }

    public override string ToString()
    {
        return 
            $"\n{Model}: " +
            $"\n  {CarEngine.ToString()} " +
            $"\n  Weigth: {(Weight == -1 ? "n/a" : Weight)} " +
            $"\n  Color: {(Color)}";
    }
}