namespace Facade;

public class HomeTheaterFacade(
    Amp amp,
    Tuner tuner,
    DvdPlayer dvdPlayer,
    CdPlayer cdPlayer,
    Projector projector,
    TheaterLights theaterLights,
    Screen screen,
    PopcornPopper popcornPopper
)
{
    public void WatchMovie(string movie)
    {
        Console.WriteLine($"Get ready to watch the movie: {movie}");
        popcornPopper.On();
        popcornPopper.Pop();
        theaterLights.Dim(10);
        screen.Down();
        projector.On();
        projector.WideScreenMode();
        amp.On();
        amp.SetDvd(dvdPlayer);
        amp.SetSurroundSound();
        amp.SetVolume(5);
        dvdPlayer.On();
        dvdPlayer.Play(movie);
    }

    public void EndMovie()
    {
        Console.WriteLine("Movie ended");
        popcornPopper.Off();
        theaterLights.On();
        screen.Up();
        projector.Off();
        amp.Off();
        dvdPlayer.Stop();
        dvdPlayer.Eject();
        dvdPlayer.Off();
    }
}