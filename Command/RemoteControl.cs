using System.Text;

namespace Command;

public class RemoteControl
{
    private readonly List<ICommand> _onCommands;
    private readonly List<ICommand> _offCommands;
    private ICommand _undoCommand;

    public RemoteControl()
    {
        var noCommand = new NoCommand();
        _onCommands = new List<ICommand>(Enumerable.Range(1, 7).Select((val) => noCommand).ToList());
        _offCommands = new List<ICommand>(Enumerable.Range(1, 7).Select((val) => noCommand).ToList());
        _undoCommand = noCommand;
    }

    public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
    {
        _onCommands[slot] = onCommand;
        _offCommands[slot] = offCommand;
    }

    public void OnButtonWasPressed(int slot)
    {
        _onCommands[slot].Execute();
        _undoCommand = _onCommands[slot];
    }
    
    public void OffButtonWasPressed(int slot)
    {
        _offCommands[slot].Execute();
        _undoCommand = _offCommands[slot];
    }

    public void UndoButtonWasPressed()
    {
        _undoCommand.Undo();
    }
    public override string ToString()
    {
        var stringBuilder = new StringBuilder();
        stringBuilder.Append("\n------ Remote Control -------");
        for (var i = 0; i < _onCommands.Count; i++)
        {
            stringBuilder.Append($"\n[slot {i}] {_onCommands[i].GetType().Name} {_offCommands[i].GetType().Name}");
        }
        
        return stringBuilder.ToString();
    }
}