namespace Services.Tests.Example1;

public class CalculatorServiceTests
{
  /// <summary>
  /// In this test we are simply checking that the result of our calculator service's Add operation works as intended
  /// </summary>
  [Fact] // You could change this to a theory and test numerous different data input scenarios
  public void TestExample1_WithNoInterfaces()
  {
    // Arrange
    var addOperation = new Services.Example1.AddOperation();
    var calculatorService = new Services.Example1.CalculatorService(addOperation);

    // Act
    var result = calculatorService.Add(5, 7);

    // Assert
    result.Should().Be(12);
  }
}