using TemperatureConverter;

namespace TemperatureConverter
{
    public class Program
    {
        public static void Main()
        {
            string userInput;
            double doubleVal;
            Console.WriteLine("Input temperature in farenheit: ");
            userInput = Console.ReadLine();



            doubleVal = Convert.ToDouble(userInput);
            TempConversion converter = new TempConversion(doubleVal);

            Console.WriteLine(converter.ToString());
        }
    }
}
