using BonusThermometer.Classes;

namespace BonusThermometer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thermometer t = new Thermometer(15, TemperatureUnit.CELSIUS);
            Console.WriteLine($"It is {t.TemperatureKelvin} degrees Kelvin, {t.TemperatureCelsius} degrees Celsius and {t.TemperatureFarenheit} degrees Farenheit outside.");
            t += 13;
            Console.WriteLine($"It is {t.TemperatureKelvin} degrees Kelvin, {t.TemperatureCelsius} degrees Celsius and {t.TemperatureFarenheit} degrees Farenheit outside.");
            t -= 17;
            Console.WriteLine($"It is {t.TemperatureKelvin} degrees Kelvin, {t.TemperatureCelsius} degrees Celsius and {t.TemperatureFarenheit} degrees Farenheit outside.");
        }
    }
}