using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary {
  public interface IMathOperation {
    double Execute(double parameter1, double parameter2);
    string ExecuteString(double parameter1, double parameter2);
  }
}
