using System;
using System.Linq; //namespace lai import gareko which gives max min 
class Methods
{
   public void Greet() => Console.WriteLine()("Hey, there!"); // arrow function
   
    public void Greet(string greeting)
    {
        Console.WriteLine($"{greeting}, there!"); //string interpolation
    }

    public float CalculateBMI(float weightInKg, float heightInFt)
    {
        var heightInM = heightInFt * 0.3048f;
        var bmi = weightInKg / (heightInM * heightInM);
        return bmi;



    }
    //variable number of arguments
    
public double GetMax( params double[] numbers) //=> numbers.Max();arrow function
{
    return numbers.Max();

}
public (int, int) GetMinMax(params int[] numbers)
{
    var smallest = numbers.Min();
    var highest = numbers.Max();
    return (smallest, highest);
}
    
}