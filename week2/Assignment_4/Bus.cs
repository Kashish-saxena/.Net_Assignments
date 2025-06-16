
public class Bus : Vehicle
{
    public string busName;

    public Bus(int year, int seats, string busName)
        : base(year, seats)
    {
        this.busName = busName;
    }
    public override void DisplayInformation()
    {
        base.DisplayInformation();
        Console.WriteLine($"Bus Name: {busName}");
    }
    public override void Start()
    {
        Console.WriteLine("Bus is starting...");
    }

    public override void Stop()
    {
        Console.WriteLine("Bus has stopped.");
    }
}
