public class Program
{
   class Program{
    static void Main(string[] args)
    {
        var converter = new FahrenheitToCelsius();
        var celsius = converter.FahrenheitToCelsiusConverter(212.0);
        Console.WriteLine($"Fahrenheit temp of 212 is {celsius}.");
    }
   }
}