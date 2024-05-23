// See https://aka.ms/new-console-template for more information
using DependencyInjector;
using MathLibrary;

Console.WriteLine("Hello, World!  We are going to do some dependency injection");
Console.WriteLine("The following are all executed by a type of calculator class that uses IMathOperation.");
Console.WriteLine("The calculator has no operation logic defined until an implementation of IMathOperation is injected into it");
Console.WriteLine();

Console.WriteLine("Constructor Dependency: The dependency is injected into the constructor and saved as a class variable ");
CalculatorConstructorInjection adder = new CalculatorConstructorInjection(new MathLibrary.Addition());
CalculatorConstructorInjection subtractor = new CalculatorConstructorInjection(new MathLibrary.Subtraction());
Console.WriteLine($"--> 100 + 50 = {adder.CalculateString(100, 50)}");
Console.WriteLine($"--> 100 - 50 = {subtractor.CalculateString(100, 50)}");
Console.WriteLine();

Console.WriteLine("Property Dependency: The dependency is injected into a class method as a property, ");
Console.WriteLine("and saved as a class variable.  If not specified, the last dependency given is used.");
CalculatorPropertyInjection calc = new CalculatorPropertyInjection();
Console.WriteLine($"--> 100 * 2 = {calc.CalculateString(100, 2, new MathLibrary.Multiplication())}");
Console.WriteLine($"--> 100 * 27 = {calc.CalculateString(100, 27)}");
Console.WriteLine($"--> 100 / 2 = {calc.CalculateString(100, 2, new MathLibrary.Division())}");
Console.WriteLine($"--> 100 / 27 = {calc.CalculateString(100, 27)}");
//note that attempting to use without giving an interface even once will compile but have various problesm
//     depending on how it was written.  
//  Perhaps attempt to use a null interface (should get error thrown)
//  Perhaps a use of a default interface if one was defined
//  As it is written now, if you try this you will get an empty value back.
//Console.WriteLine($"--> 100 / 25 = {new CalculatorPropertyInjection().CalculateString(100, 25)}");

Console.WriteLine();

Console.WriteLine("Method Dependency: The dependency is required to be given as a parameter in every method");
Console.WriteLine("that uses it.");
CalculatorMethodInjection calc2 = new CalculatorMethodInjection();
Console.WriteLine($"--> 6 ^ 2 = {calc2.CalculateString(new MathLibrary.Power(), 6, 2)}");
Console.WriteLine($"--> 7 ^ 3 = {calc2.CalculateString(new MathLibrary.Power(), 7, 3)}");
Console.WriteLine($"--> 6 % 2 = {calc2.CalculateString(new MathLibrary.Modulus(), 6, 2)}");
Console.WriteLine($"--> 16 % 3 = {calc2.CalculateString(new MathLibrary.Modulus(), 16, 3)}");

// Note that attempting to use without an interface given will not compile
//Console.WriteLine($"--> 16 % 3 = {calc2.CalculateString(16, 3)}");
Console.WriteLine();
Console.WriteLine("Done!");


