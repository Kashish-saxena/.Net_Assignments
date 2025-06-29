using Microsoft.Extensions.Configuration;

var builder = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

IConfiguration config = builder.Build();

string filePath = config["FilePath:destination"]; 
string dbConnection = config["DbConnection:connectionString"];
Console.WriteLine($"FilePath: {filePath}");
Console.WriteLine($"DbConnection: {dbConnection}");

