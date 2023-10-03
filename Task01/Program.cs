// Raw Data

int carsNumber = int.Parse(Console.ReadLine());
Car[] cars = new Car[carsNumber];

for (int i = 0; i < carsNumber; i++)
{
    string[] values = Console.ReadLine().Split();

    string model = values[0];
    int engineSpeed = int.Parse(values[1]);
    int enginePower = int.Parse(values[2]);
    int cargoWeight = int.Parse(values[3]);
    string cargoType = values[4];
    double tire1Pressure = double.Parse(values[5]);
    int tire1Age = int.Parse(values[6]);
    double tire2Pressure = double.Parse(values[7]);
    int tire2Age = int.Parse(values[8]);
    double tire3Pressure = double.Parse(values[9]);
    int tire3Age = int.Parse(values[10]);
    double tire4Pressure = double.Parse(values[11]);
    int tire4Age = int.Parse(values[12]);

    cars[i] = new Car(
        model,
        engineSpeed, enginePower,
        cargoWeight, cargoType,
        tire1Pressure, tire1Age,
        tire2Pressure, tire2Age,
        tire3Pressure, tire3Age,
        tire4Pressure, tire4Age
        );
}

string command = Console.ReadLine();
Car[] filteredCars;
if (string.Equals(command, "flamable"))
{
    filteredCars = cars
        .Where(car => car.CarEngine.EnginePower > 250)
        .ToArray();
}
else
{
    filteredCars = cars
        .Where(car => car.CarTires.Select(tire => tire.Pressure).Min() < 1)
        .ToArray();
}

foreach (Car car in filteredCars)
{
    Console.WriteLine(car.Model);
}
