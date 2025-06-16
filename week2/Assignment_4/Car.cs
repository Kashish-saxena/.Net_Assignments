
public class Car : Vehicle
{
    public string carName;
    public Car(int year, int seats, string carName)
        : base(year, seats)
    {
        this.carName = carName;
    }

    public override void DisplayInformation()
    {
        base.DisplayInformation();
        Console.WriteLine($"Car Name: {carName}");
    }

    public override void Start()
    {
        Console.WriteLine("Car is starting.");
    }

    public override void Stop()
    {
        Console.WriteLine("Car has stopped.");
    }
}
