namespace Observer;

public class WeatherData : ISubject
{
    private readonly List<IObserver> _observers = [];
    private float _temperature;
    private float _humidity;
    private float _pressure;

    public void registerObserver(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void removeObserver(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void notifyObservers()
    {
        foreach (var observer in _observers)
        {
            observer.update(_temperature, _humidity, _pressure);
        }
    }

    private void MeasurementsChanged()
    {
        notifyObservers();
    }

    public void SetMeasurements(float temperature, float humidity, float pressure)
    {
        this._temperature = temperature;
        this._humidity = humidity;
        this._pressure = pressure;
        MeasurementsChanged();
    }
}