// See https://aka.ms/new-console-template for more information

using Microsoft.Extensions.DependencyInjection;

var serviceProvider = new ServiceCollection()
            .AddSingleton<Assignment_10.ICalculator, Assignment_10.Calculator>()
            .BuildServiceProvider();

var calculator = serviceProvider.GetService<Assignment_10.ICalculator>();
calculator?.Calculate();
