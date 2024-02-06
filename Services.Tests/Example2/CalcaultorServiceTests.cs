namespace Services.Tests.Example2;

public class CalcaultorServiceTests
{
  /// <summary>
  /// In this test we are again testing our calculator's Add operation
  /// However, we have taken the AddOperation implementation detail out of the equation
  /// Remember this is a CalculatorService test, therefore we want to limit the testing scope to only the CalculatorService
  /// (We can have separate tests that specifically test the AddOperation functionality)
  /// </summary>
  [Fact]
  public void TestExample2_WithInterfaces()
  {
    // Arrange
    var (inputA, inputB, expectedResult) = (5, 7, 12);
    var mockedAddOperation = Substitute.For<Services.Example2.IAddOperation>();
    mockedAddOperation.Configure().Execute(inputA, inputB).Returns(expectedResult);
    var mockedCalculatorService = Substitute.ForPartsOf<Services.Example2.CalculatorService>(mockedAddOperation);

    // Act
    var result = mockedCalculatorService.Add(inputA, inputB);

    // Assert
    result.Should().Be(expectedResult);
  }
}