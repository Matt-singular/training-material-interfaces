namespace Services.Example3;

public class CalculatorService
{
  private ICalculatorOperation? calculatorOperation;

  public CalculatorService(ICalculatorOperation? calculatorOperation)
  {
    this.calculatorOperation = calculatorOperation;
  }

  public CalculatorService()
  {
    // Allows for it to be instantiated without supplying an initial calculator operation
  }

  public decimal ExecuteOperation(decimal a, decimal b)
  {
    if (this.calculatorOperation == null)
    {
      throw new InvalidOperationException("You shouldn't throw exceptions :P");
    }

    var result = this.calculatorOperation.Execute(a, b);

    return result;
  }

  public CalculatorService SetOperation(ICalculatorOperation newOperation)
  {
    // Change the calculator operation
    this.calculatorOperation = newOperation;

    // This is just to allow chaining of the ExecuteOperation function
    return this;
  }
}