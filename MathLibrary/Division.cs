using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary {
  internal class Division : IMathOperation {
    public double Execute(double parameter1, double parameter2) {
      if (parameter2 == 0) return 0; //for simplicity, catch this case
      return parameter1 / parameter2;
    }
    public string ExecuteString(double parameter1, double parameter2) {
      return Execute(parameter1, parameter2).ToString();
    }
  }
}
