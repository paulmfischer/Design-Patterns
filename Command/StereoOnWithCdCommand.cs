namespace Command;

public class StereoOnWithCdCommand(Stereo stereo) : ICommand
{
    public void Execute()
    {
        stereo.On();
        stereo.SetCd();
        stereo.SetVolume(3);
    }

    public void Undo()
    {
        stereo.Off();
    }
}