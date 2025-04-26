namespace State;

public class WinnerState(GumballMachine gumballMachine): IState
{
    public void InsertQuarter()
    {
        Console.WriteLine("Please wait, we are already giving you a gumball");
    }

    public void EjectQuarter()
    {
        Console.WriteLine("Sorry, you already turned the crank");
    }

    public void TurnCrank()
    {
        Console.WriteLine("Turning twice doesn't get you another gumball");
    }

    public void Dispense()
    {
        Console.WriteLine("YOU ARE A WINNER, you get two gumballs for your quarter");
        gumballMachine.ReleaseBall();
        if (gumballMachine.GetCount() == 0)
        {
            gumballMachine.SetState(gumballMachine.SoldOutState);
        }
        else
        {
            gumballMachine.ReleaseBall();
            if (gumballMachine.GetCount() > 0)
            {
                gumballMachine.SetState(gumballMachine.NoQuarterState);
            }
            else
            {
                Console.WriteLine("Gumball machine is now out of gumballs");
                gumballMachine.SetState(gumballMachine.SoldOutState);
            }
        }
    }
}