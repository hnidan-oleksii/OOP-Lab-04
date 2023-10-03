// Car Salesman 

int enginesNumber = int.Parse(Console.ReadLine());
Engine[] engines = new Engine[enginesNumber];

for (int i = 0; i < enginesNumber; i++)
{
    string[] values = Console.ReadLine().Split();

    string model = values[0];
    int power = int.Parse(values[1]);
    int displacement = -1;
    string? efficiency = null;

    if (values.Length > 2)
    {
        bool isDisplacement = int.TryParse(values[2], out displacement);

        if (!isDisplacement)
        {
            efficiency = values[2];
        }
        else if (values.Length == 4)
        {
            efficiency = values[3];
        }
    }

    engines[i] = new Engine(model, power, displacement, efficiency);
}

int carsNumber = int.Parse(Console.ReadLine());
Car[] cars = new Car[carsNumber];

for (int i = 0; i < carsNumber; i++)
{
    string[] values = Console.ReadLine().Split();

    string model = values[0];
    Engine engine = engines.First(engine => string.Equals(engine.Model, values[1]));
    int weight = -1;
    string? color = null;

    if (values.Length > 2)
    {
        bool isWeight = int.TryParse(values[2], out weight);

        if (!isWeight)
        {
            color = values[2];
        }
        else if (values.Length == 4)
        {
            color = values[3];
        }
    }

    cars[i] = new Car(model, engine, weight, color);
}

foreach (Car car in cars)
{
    Console.WriteLine(car);
}
