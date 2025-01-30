// Tyler Hughes
// 1/29/2025

namespace TemperatureConverter
{
    // base values


    public class TempConversion
    {
        // User enters temperature in Farenheit
        // You should construct a class that allows degrees Farenheit
        // To be converted to Celcius, Kelvin, and Rankine

        // constructors

        public double farenheit;


        public TempConversion(double farenheitTemp)
        {
            this.farenheit = farenheitTemp;

        }

        public double Celcius()
        {
            double celcius = ((farenheit - 32) * (5.0 / 9.0));
            return celcius;

        }
        public double Kelvin()
        {

            double kelvin = (((farenheit - 32) * (5.0 / 9.0)) + 273.15);
            return kelvin;

        }

        public double Rankine()
        {
            double rankine = (farenheit + 459.67);
            return rankine;


        }

        // methods
        public override string ToString()
        {

            string message = "";
            message = message + "Celcius: " + this.Celcius() + "\n";
            message = message + "Kelvin: " + this.Kelvin() + "\n";
            message = message + "Rankine: " + this.Rankine() + "\n";

            return message;

        }

    }
}
