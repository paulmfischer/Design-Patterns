// See https://aka.ms/new-console-template for more information

using Adapter;

var duck = new Mallard();
var turkey = new WildTurkey();

var turkeyAdapter = new TurkeyAdapter(turkey);
Console.WriteLine("The turkey says....");
turkey.Gobble();
turkey.Fly();

Console.WriteLine("The duck says...");
duck.Quack();
duck.Fly();

Console.WriteLine("The turkey adapter says....");
turkeyAdapter.Quack();
turkeyAdapter.Fly();