using Application;
using Microsoft.Extensions.DependencyInjection;

// Dependency Injection
var serviceProvider = new ServiceCollection()
  .AddExampleServices()
  .BuildServiceProvider();

// Execute Examples - Not used
//var applicationOrchestration = serviceProvider.GetRequiredService<IOrchestration>();
//applicationOrchestration.Process();