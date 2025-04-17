namespace Observer;

public interface IObserver
{
   void update(float temp, float humidity, float pressure);
}

public interface ISubject
{
   void registerObserver(IObserver observer); 
   void removeObserver(IObserver observer);
   void notifyObservers();
}

public interface IDisplayElement
{
   void display();
}