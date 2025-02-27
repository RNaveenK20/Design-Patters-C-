using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Design_Patterns.Factory_Pattern;
using Design_Patterns.Observer_Pattern;
using Singleton;

namespace Design_Patterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger logger1 = Logger.Instance;
            Logger logger2 = Logger.Instance;

            // Checking if both instances are the same
            Console.WriteLine(Object.ReferenceEquals(logger1, logger2) ? "Logger is Singleton" : "Logger is NOT Singleton");

            // Logging messages
            logger1.Log("Application Started");
            logger2.Log("Logging another message");

            // Factory Pattern Demo
            IDocument pdfDoc = DocumentFactory.CreateDocument("pdf");
            pdfDoc.Open();
            IDocument wordDoc = DocumentFactory.CreateDocument("word");
            wordDoc.Open();

            // Observer Pattern Demo
            WeatherStation weatherStation = new WeatherStation();
            WeatherDisplay display1 = new WeatherDisplay();
            WeatherDisplay display2 = new WeatherDisplay();

            weatherStation.RegisterObserver(display1);
            weatherStation.RegisterObserver(display2);

            weatherStation.SetTemperature(25.5f);
            weatherStation.SetTemperature(30.2f);
        }
    }
}
