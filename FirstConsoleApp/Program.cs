﻿using System;

Console.WriteLine("I am main");

Datatypes dt = new();
dt.Learn();

Methods m = new();
m.Greet("Hi");
m.Greet("Namaste");

m.Greet("fullName");

//
using System;
//1.Print the value of  full name to console

Console.WriteLine("Enter Your Full Name");

// Define a variable fullName and assign a name


string fullName = "Rakshya Kunwar";
Console.WriteLine(fullName);
Console.ReadLine();

//
using System;

//2 define another variable cFullName and initilize it with fullName in uppercase letters

string fullName = "Rakshya Kunwar";
string cFullName = fullName.ToUpper();
Console.WriteLine( $"Hello, {cFullName} Ji!");
//
using System;

// 3 instead of initilizing fullname, get it from user

Console.WriteLine("Enter your Full Name:");
string fullName = Console.ReadLine();
Console.WriteLine($"Hello, {fullName}");

//
using System;
//4. to enter date of birth

Console.WriteLine("Enter your full name:");
string fullName = Console.ReadLine();
string cFullName = fullName.ToUpper();

Console.WriteLine("Enter your Date of Birth as (YYYY/MM/DD):");
DateTime DOB = DateTime.Parse(Console.ReadLine()); 
// DateTime today = DateTime.Today;
Console.WriteLine($"Hello, {cFullName} Ji!");
Console.WriteLine($"Your DOB: {DOB.ToString("dddd, dd MMMM yyyy")}");

//







