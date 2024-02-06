namespace Services.Example1;

public class CalculatorService
{
  // Services we use
  private readonly AddOperation addOperation;

  // Create a concrete instance of the CalculatorService class
  public CalculatorService(AddOperation addOperation)
  {
    this.addOperation = addOperation;
  }

  public decimal Add(decimal a, decimal b)
  {
    var result = this.addOperation.Execute(a, b);

    return result;
  }

  // Alternative implementation (don't define addOperation at the top)
  //public decimal Add(decimal a, decimal b)
  //{
  //  var addOperation = new AddOperation();
  //  var result = addOperation.Execute(a, b);

  //  return result;
  //}
}