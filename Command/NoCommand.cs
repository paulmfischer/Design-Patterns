namespace Command;

public class NoCommand : ICommand
{
    public void Execute()
    {
        Console.WriteLine("NoCommand");
    }

    public void Undo()
    {
        Console.WriteLine("NoCommand Undo");
    }
}