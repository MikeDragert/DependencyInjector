using MathLibrary;

namespace DependencyInjector {
  public class CalculatorMethodInjection {
    public CalculatorMethodInjection() {
    }

    public double Calculate(MathLibrary.IMathOperation mathOperation, double parameter1, double parameter2) {
      return mathOperation.Execute(parameter1, parameter2);
    }
    public string CalculateString(MathLibrary.IMathOperation mathOperation, double parameter1, double parameter2) {
      return mathOperation.ExecuteString(parameter1, parameter2);
    }
  }
}
