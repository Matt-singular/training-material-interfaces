namespace Services.Tests.Example3;

public class CalcaultorServiceTests
{
  /// <summary>
  /// In this test we are showing of the versatility of using interfaces.
  /// This is a regular unit test, so we are again mocking functionality that isn't defined in our calculator service
  /// This means the unit of work being tested is limited to the CalculatorService
  /// </summary>
  [Fact]
  public void TestExample3_WithStrategyPattern_UnitTest()
  {
    // Arrange
    var (inputA, inputB, expectedResultAB) = (5, 7, 12);
    var (inputC, inputD, expectedResultCD) = (12, 3, 9);

    var mockedAddOperation = Substitute.For<Services.Example3.ICalculatorOperation>();
    mockedAddOperation.Configure().Execute(inputA, inputB).Returns(expectedResultAB);

    var mockedMinusOperation = Substitute.For<Services.Example3.ICalculatorOperation>();
    mockedMinusOperation.Configure().Execute(inputC, inputD).Returns(expectedResultCD);

    var mockedCalculatorService = Substitute.ForPartsOf<Services.Example3.CalculatorService>();

    // Act
    var actualResultAB = mockedCalculatorService.SetOperation(mockedAddOperation).ExecuteOperation(inputA, inputB);
    var actualResultCD = mockedCalculatorService.SetOperation(mockedMinusOperation).ExecuteOperation(inputC, inputD);

    // Assert
    actualResultAB.Should().Be(expectedResultAB);
    actualResultCD.Should().Be(expectedResultCD);
  }

  /// <summary>
  /// This is another test, but this time we are working with classes and calling their actual functionality.
  /// This is not a unit test as we are no longer testing a unit of work but rather testing how different parts of the system work together.
  /// This is called an integration test.
  /// </summary>
  [Fact]
  public void TestExample3_WithStrategyPattern_IntegrationTest()
  {
    // Arrange
    var (inputA, inputB, expectedResultAB) = (5, 7, 12);
    var (inputC, inputD, expectedResultCD) = (12, 3, 9);

    // explicitly using the AddOperation (which means this logic is running)
    var mockedAddOperation = Substitute.ForPartsOf<Services.Example3.AddOperation>();

    // explicitly using the AddOperation (which means this logic is running)
    var mockedMinusOperation = Substitute.ForPartsOf<Services.Example3.MinusOperation>(); 

    var mockedCalculatorService = Substitute.ForPartsOf<Services.Example3.CalculatorService>();

    // Act
    var actualResultAB = mockedCalculatorService.SetOperation(mockedAddOperation).ExecuteOperation(inputA, inputB);
    var actualResultCD = mockedCalculatorService.SetOperation(mockedMinusOperation).ExecuteOperation(inputC, inputD);

    // Assert
    actualResultAB.Should().Be(expectedResultAB);
    actualResultCD.Should().Be(expectedResultCD);
  }
}