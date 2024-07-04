namespace Temparature_Converter.Service
{
    public class TemperatureConversion
    {
        public static double Fahrenheit(double f)
        {
            var c = (f - 32) * 5 / 9;
            return c;

        }
        public static double celsius(double c)
        {
            var f = (c * 9 / 5) + 32;
            return f;
            
        }
    }
}
