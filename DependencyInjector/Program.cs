// See https://aka.ms/new-console-template for more information
using DependencyInjector;
using MathLibrary;

Console.WriteLine("Hello, World!  We are going to do some dependency injection");

Console.WriteLine("Constructor Dependendy: ");

IMathOperation addition = new MathLibrary.Addition();

CalculatorConstructorInjection adder = new CalculatorConstructorInjection(new MathLibrary.Addition());
CalculatorConstructorInjection subtractor = new CalculatorConstructorInjection(new MathLibrary.Subtraction());

Console.WriteLine($"--> 100 + 50 = {adder.CalculateString(100, 50)}");
Console.WriteLine($"--> 100 - 50 = {subtractor.CalculateString(100, 50)}");


