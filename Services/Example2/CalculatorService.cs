namespace Services.Example2;

public class CalculatorService
{
  // Services we use
  private readonly IAddOperation addOperation;

  // Create a concrete instance of the CalculatorService class
  public CalculatorService(IAddOperation addOperation)
  {
    this.addOperation = addOperation;
  }

  public decimal Add(decimal a, decimal b)
  {
    var result = this.addOperation.Execute(a, b);

    return result;
  }
}