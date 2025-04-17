namespace Observer;

public class CurrentConditionsDisplay : IObserver, IDisplayElement
{
    private float _temperature;
    private float _humidity;
    private readonly ISubject _weatherData;

    public CurrentConditionsDisplay(ISubject weatherData)
    {
        _weatherData = weatherData;
        _weatherData.registerObserver(this);
    }
    
    public void update(float temp, float humidity, float pressure)
    {
        _temperature = temp;
        _humidity = humidity;
        display();
    }

    public void display()
    {
        Console.WriteLine($"Current Conditions: {_temperature}F degrees and {_humidity}% humidity");
    }
}