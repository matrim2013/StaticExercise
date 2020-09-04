using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double fahrenheit) 
        {
            return (fahrenheit - 32) * 5 / 9; 
        }
        public static double CelsiusToFahrenheit(double celsius) 
        {
            return (celsius / 5 * 9) + 32;
        }

    }
}
