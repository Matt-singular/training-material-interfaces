﻿namespace Services.Example3;

public class AddOperation : ICalculatorOperation
{
  public decimal Execute(decimal a, decimal b)
  {
    var result = a + b;

    return result;
  }
}