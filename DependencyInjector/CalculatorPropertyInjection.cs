using MathLibrary;

namespace DependencyInjector {
  public class CalculatorPropertyInjection {
    MathLibrary.IMathOperation? _mathOperation;
    public CalculatorPropertyInjection() {
    }
    public double Calculate(double parameter1, double parameter2, MathLibrary.IMathOperation? mathOperation = null) {
      if (mathOperation != null) {
        _mathOperation = mathOperation;
      }
      if (_mathOperation != null) {
        return _mathOperation.Execute(parameter1, parameter2);
      }
      return 0; //throw error in production version
    }
    public string CalculateString(MathLibrary.IMathOperation mathOperation, double parameter1, double parameter2) {
      if (mathOperation != null) {
        _mathOperation = mathOperation;
      }
      if (_mathOperation != null) {
        return _mathOperation.ExecuteString(parameter1, parameter2);
      }
      return ""; //throw error in production version
    }
  }
}
