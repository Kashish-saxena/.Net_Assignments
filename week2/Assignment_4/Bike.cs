
public class Bike : Vehicle
{
    public string bikeName;
    public Bike(int year, int seats, string bikeName) : base(year, seats)
    {
        this.bikeName = bikeName;
    }
    public override void DisplayInformation()
    {
        base.DisplayInformation();
        Console.WriteLine($"Bike Name: {bikeName}");
    }
    public override void Start()
    {
        Console.WriteLine("Bike is starting...");
    }

    public override void Stop()
    {
        Console.WriteLine("Bike has stopped.");
    }
}