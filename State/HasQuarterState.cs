namespace State;

public class HasQuarterState(GumballMachine gumballMachine) : IState
{
    private readonly Random _randomWinner = new Random();
    
    public void InsertQuarter()
    {
        Console.WriteLine("You can't insert another quarter");
    }

    public void EjectQuarter()
    {
        Console.WriteLine("Quarter returned");
        gumballMachine.SetState(gumballMachine.NoQuarterState);
    }

    public void TurnCrank()
    {
        Console.WriteLine("You turned....");
        var winner = _randomWinner.Next(10);
        if (winner == 0 && gumballMachine.GetCount() > 1)
        {
            gumballMachine.SetState(gumballMachine.WinnerState);
        }
        else
        {
            gumballMachine.SetState(gumballMachine.SoldState);
        }
    }

    public void Dispense()
    {
        Console.WriteLine("No gumball dispensed");
    }
}