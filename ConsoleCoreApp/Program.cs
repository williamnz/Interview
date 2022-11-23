// See https://aka.ms/new-console-template for more information
using ConsoleCoreApp.Inheritance;
using ConsoleCoreApp.Other;

Console.WriteLine("Hello, World!");

var employee2 = new Employee2("John Doe");

LearnYield a = new LearnYield();
a.Test0();

var apple = new { Item = "apples", Price = 1.35 };
var onSale = apple with { Price = 0.79 };
Console.WriteLine(apple);
Console.WriteLine(onSale);