using System;

namespace CelsiusConv
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius;
            Console.WriteLine(" Please enter your temperature in celsius:");
            celsius = Convert.ToDouble(Console.ReadLine());

            CelsConv fah = new CelsConv(celsius);
            fah.ConvertToFah();

            Console.ReadLine();
        }
    }

    class CelsConv
    {
        double celsius;
        public CelsConv( double celsius)
        {
            this.celsius = celsius;

        }
        public void ConvertToFah()
        {
            double fah = (celsius * 1.8) + 32;
            Console.WriteLine("temperature in {0}  celsuis = {1} in fahrenheit", celsius, fah);

        }
    }
}
