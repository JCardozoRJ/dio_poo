using poo.src.Entities;
// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
var knight = new Knight("Pedro", 42, "Knight", 469, 72);
var wizard = new Wizard("Joana", 42, "Wizard", 325, 474);
var ninja = new Ninja("Caio", 42, "Ninja", 292, 89);
Console.WriteLine(knight);
Console.WriteLine(knight.Attack(wizard.Name));
Console.WriteLine(wizard);
Console.WriteLine(wizard.Attack(knight.Name));
Console.WriteLine(ninja);
Console.WriteLine(ninja.Attack(knight.Name));
Console.WriteLine(ninja.Attack(7));