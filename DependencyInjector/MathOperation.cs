using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjector {
  internal interface MathOperation {
    double Execute(double parameter1, double parameter2);
    string ExecuteString(double parameter1, double parameter2);
  }
}
