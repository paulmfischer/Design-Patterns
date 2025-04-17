namespace Facade;

public class Amp
{
    public void On() => Console.WriteLine("Amp On");
    public void Off() => Console.WriteLine("Amp Off");
    public void SetDvd(DvdPlayer dvd) => Console.WriteLine("Amp Set to Dvd");
    public void SetSurroundSound() => Console.WriteLine("Amp Set to Surround Sound");
    public void SetVolume(int volume) => Console.WriteLine($"Amp Set to Volume {volume}");
}

public class Tuner
{
}

public class DvdPlayer
{
    public void On() => Console.WriteLine("Dvd Player On");
    public void Off() => Console.WriteLine("Dvd Player Off");
    public void Play(string movie) => Console.WriteLine($"Dvd Player Playing {movie}");
    public void Stop() => Console.WriteLine("Dvd Player Stop");
    public void Eject() => Console.WriteLine("Dvd Player Eject");
}

public class CdPlayer
{
}

public class Projector
{
    public void On() => Console.WriteLine("Projector On");
    public void Off() => Console.WriteLine("Projector Off");
    public void WideScreenMode() => Console.WriteLine("Wide Screen Mode");
}

public class TheaterLights
{
    public void Dim(int value) => Console.WriteLine($"Dimming lights to: {value}");
    public void On() => Console.WriteLine("Lights On");
}

public class Screen
{
    public void Up() => Console.WriteLine("Screen Up");
    public void Down() => Console.WriteLine("Screen Down");
}

public class PopcornPopper
{
    public void On() => Console.WriteLine("Popcorn machine On");
    public void Off() => Console.WriteLine("Popcorn machine Off");
    public void Pop() => Console.WriteLine("Popcorn machine Popping");
}