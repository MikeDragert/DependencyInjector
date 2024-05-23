// See https://aka.ms/new-console-template for more information
using DependencyInjector;
using MathLibrary;

Console.WriteLine("Hello, World!  We are going to do some dependency injection");

Console.WriteLine("Constructor Dependency: ");

CalculatorConstructorInjection adder = new CalculatorConstructorInjection(new MathLibrary.Addition());
CalculatorConstructorInjection subtractor = new CalculatorConstructorInjection(new MathLibrary.Subtraction());

Console.WriteLine($"--> 100 + 50 = {adder.CalculateString(100, 50)}");
Console.WriteLine($"--> 100 - 50 = {subtractor.CalculateString(100, 50)}");
Console.WriteLine();

Console.WriteLine("Property Dependency: ");
CalculatorPropertyInjection calc = new CalculatorPropertyInjection();

Console.WriteLine($"--> 100 * 2 = {calc.CalculateString(100, 2, new MathLibrary.Multiplication())}");
Console.WriteLine($"--> 100 * 27 = {calc.CalculateString(100, 27)}");
Console.WriteLine($"--> 100 / 2 = {calc.CalculateString(100, 2, new MathLibrary.Division())}");
Console.WriteLine($"--> 100 / 27 = {calc.CalculateString(100, 27)}");