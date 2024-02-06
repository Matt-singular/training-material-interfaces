using Application;
using Microsoft.Extensions.DependencyInjection;
using Services.Example2;

// Dependency Injection
var serviceProvider = new ServiceCollection()
  .AddExampleServices()
  .BuildServiceProvider();

// Execute Examples - Demonstrate dependency injection
var addOperation = serviceProvider.GetRequiredService<IAddOperation>();
var result = addOperation.Execute(5, 6);

// Write the results and keep the terminal open
Console.Write(result);
Console.ReadLine();