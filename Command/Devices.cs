namespace Command;

public class Light(string Name)
{
    public void On()
    {
        Console.WriteLine($"{Name} Light is On");
    }

    public void Off()
    {
        Console.WriteLine($"{Name} Light is Off");
    }
}

public class Stereo
{
    public void On()
    {
        Console.WriteLine("Stereo is On");
    }

    public void Off()
    {
        Console.WriteLine("Stereo is Off");
    }

    public void SetCd()
    {
        Console.WriteLine("Stereo CD set");
    }

    public void SetVolume(int volume)
    {
        Console.WriteLine($"Stereo Volume set to {volume}");
    }
}