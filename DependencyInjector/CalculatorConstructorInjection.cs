using MathLibrary;

namespace DependencyInjector {
  public class CalculatorConstructorInjection {
    private MathLibrary.IMathOperation _mathOperation;
    public CalculatorConstructorInjection(MathLibrary.IMathOperation mathOperation) {
      _mathOperation = mathOperation;
    }

    public double Calculate(double parameter1, double parameter2) {
      return _mathOperation.Execute(parameter1, parameter2);
    }
    public string CalculateString(double parameter1, double parameter2) {
      return _mathOperation.ExecuteString(parameter1, parameter2);
    }
  }
}
