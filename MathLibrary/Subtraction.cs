using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary {
  public class Subtraction : IMathOperation {
    public double Execute(double parameter1, double parameter2) {
      return parameter1 - parameter2;
    }
    public string ExecuteString(double parameter1, double parameter2) {
      return Execute(parameter1, parameter2).ToString();
    }
  }
}
