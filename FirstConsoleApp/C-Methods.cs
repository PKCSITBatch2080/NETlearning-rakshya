using System;
class Methods
{
    void Greet()
    {
Console.WriteLine("Hey, there!");
    }
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
    

    
}