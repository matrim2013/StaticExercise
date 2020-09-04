using StaticExercise;
using System;

namespace StaticExcerise
{
    class Program
    {
        static void Main(string[] args)
        {
           var fahrenheit = TempConverter.CelsiusToFahrenheit(0);
           var celsius = TempConverter.FahrenheitToCelsius(212);

            Console.WriteLine($"Freezing temp for water in F is {fahrenheit}");
            Console.WriteLine($"While the boiling point in C is {celsius}");
        }
    }
}
