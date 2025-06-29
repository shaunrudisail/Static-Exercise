namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var fahrenheit = 0;
            var celsius = 32;
            
            Console.WriteLine(TempConverter.FahrenheitToCelsius(fahrenheit));
            Console.WriteLine(TempConverter.CelsiusToFahrenheit(celsius));
        }
    }
}
