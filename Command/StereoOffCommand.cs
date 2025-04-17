namespace Command;

public class StereoOffCommand(Stereo stereo) : ICommand
{
    public void Execute()
    {
        stereo.Off();
    }

    public void Undo()
    {
        stereo.On();
    }
}