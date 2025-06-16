public abstract class Vehicle
{
    private int year;
    private int numberOfSeats;
    public Vehicle(int year, int numberOfSeats)
    {
        this.year = year;
        this.numberOfSeats = numberOfSeats;
    }

    public virtual void DisplayInformation()
    {
        Console.WriteLine($"Manufacturing year: {year}, Seat Capacity: {numberOfSeats}");
    }

    public abstract void Start();
    public abstract void Stop();
}
