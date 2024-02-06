namespace Services.Example2;

public class AddOperation : IAddOperation
{
  public decimal Execute(decimal a, decimal b)
  {
    var result = a + b;

    return result;
  }
}