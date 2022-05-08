// See https://aka.ms/new-console-template for more information
using github_actions_demo;

Console.Write("Input: ");
var input = Console.ReadLine();
var output = Calculator.Calculate(input);
Console.WriteLine("Output: " + output);