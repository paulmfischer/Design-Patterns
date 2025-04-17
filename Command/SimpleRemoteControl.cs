namespace Command;

public class SimpleRemoteControl
{
    private ICommand _slot;

    public void SetCommand(ICommand slot)
    {
        _slot = slot;
    }

    public void ButtonWasPressed()
    {
        _slot.Execute();
    }
}