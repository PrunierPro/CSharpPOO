using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusThermometer.Classes
{
    internal enum TemperatureUnit
    {
        KELVIN,
        CELSIUS,
        FARENHEIT
    }
    internal class Thermometer
    {

        private double _temperatureKelvin;

        public double TemperatureKelvin { get => _temperatureKelvin; set => _temperatureKelvin = value; }
        public double TemperatureCelsius { get => _temperatureKelvin - 273.15; set => _temperatureKelvin = value + 273.15; }
        public double TemperatureFarenheit { get => TemperatureCelsius * (9 / 5) + 32; set => _temperatureKelvin = (value - 32) * (9 / 5) + 273.15; }

        public Thermometer(double temperature, TemperatureUnit unit)
        {
            switch (unit)
            {
                case TemperatureUnit.KELVIN:
                    TemperatureKelvin = temperature;
                    break;
                case TemperatureUnit.CELSIUS:
                    TemperatureCelsius = temperature;
                    break;
                case TemperatureUnit.FARENHEIT:
                    TemperatureFarenheit = temperature;
                    break;
            }
        }

        public static Thermometer operator +(Thermometer t, double number) => new Thermometer(t.TemperatureKelvin + number, TemperatureUnit.KELVIN);
        public static Thermometer operator -(Thermometer t, double number) => new Thermometer(t.TemperatureKelvin - number, TemperatureUnit.KELVIN);
    }
}
