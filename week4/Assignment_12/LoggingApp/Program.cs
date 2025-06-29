public class Program
{
    public static void Main(string[] args)
    {
        var host = CreateHostBuilder(args)
            .Build();
        var service = host.Services.GetRequiredService<LoggingService>();
        service.PrintLogs();
        Console.ReadLine();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
        .ConfigureServices((context, services) =>
            {
                services.AddTransient<LoggingService>();

            });
}



