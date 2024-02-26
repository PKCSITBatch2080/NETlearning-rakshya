using System;

Console.WriteLine("I am main");

Datatypes dt = new();
dt.Learn();

Methods m = new();
m.Greet("Hi");
m.Greet("Namaste");

m.Greet("fullName");

var highest = m.GetMax(3,4,5,6,34.6,44.6);
var highest = m.GetMax(3,4,5,6);
var highest = m.GetMax(3,4,5,6,34.6,44.6, 23.4);
var highest = m.GetMax(3,4);