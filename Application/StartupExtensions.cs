namespace Application;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

public static class StartupExtensions
{
  public static ServiceCollection AddExampleServices(this ServiceCollection serviceCollection)
  {
    // Example Services
    serviceCollection.TryAddScoped<Services.Example2.IAddOperation, Services.Example2.AddOperation>();

    return serviceCollection;
  }
}