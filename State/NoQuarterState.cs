namespace State;

public class NoQuarterState(GumballMachine gumballMachine) : IState
{
    public void InsertQuarter()
    {
        Console.WriteLine("You inserted a quarter");
        gumballMachine.SetState(gumballMachine.HasQuarterState);
    }

    public void EjectQuarter()
    {
        Console.WriteLine("You have not inserted a quarter");
    }

    public void TurnCrank()
    {
        Console.WriteLine("You turned but there is no quarter");
    }

    public void Dispense()
    {
        Console.WriteLine("You need to pay first");
    }
}