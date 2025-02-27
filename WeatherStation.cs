using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Observer_Pattern
{
    public interface IObserver
    {
        void Update(float temperature);
    }

    public class WeatherDisplay : IObserver
    {
        public void Update(float temperature)
        {
            Console.WriteLine($"Weather updated: {temperature}°C");
        }
    }

    public class WeatherStation
    {
        private List<IObserver> _observers = new List<IObserver>();
        private float _temperature;

        public void RegisterObserver(IObserver observer) => _observers.Add(observer);
        public void UnregisterObserver(IObserver observer) => _observers.Remove(observer);
        public void SetTemperature(float temperature)
        {
            _temperature = temperature;
            NotifyObservers();
        }
        private void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_temperature);
            }
        }
    }
}
