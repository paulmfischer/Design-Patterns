namespace State;

public class GumballMachine
{
    // private const int SoldOut = 0;
    // private const int NoQuarter = 1;
    // private const int HasQuarter = 2;
    // private const int Sold = 3;
    //
    // private int _state = SoldOut;
    public readonly IState SoldOutState;
    public readonly IState NoQuarterState;
    public readonly IState HasQuarterState;
    public readonly IState SoldState;
    public readonly IState WinnerState;
    
    private IState _state;
    private int _count = 0;

    public GumballMachine(int count)
    {
        SoldOutState = new SoldOutState(this);
        NoQuarterState = new NoQuarterState(this);
        HasQuarterState = new HasQuarterState(this);
        SoldState = new SoldState(this);
        WinnerState = new WinnerState(this);
        
        _state = SoldOutState;
        
        _count = count;
        if (_count > 0)
        {
            _state = NoQuarterState;
        }
    }

    public void InsertQuarter()
    {
        _state.InsertQuarter();
        // switch (_state)
        // {
        //     case HasQuarter:
        //         Console.WriteLine("You can't insert another quarter");
        //         break;
        //     case NoQuarter:
        //         _state = HasQuarter;
        //         Console.WriteLine("You inserted a quarter");
        //         break;
        //     case SoldOut:
        //         Console.WriteLine("You can't insert another quarter, machine is sold out");
        //         break;
        //     case Sold:
        //         Console.WriteLine("Please wait, we are already giving you a gumball");
        //         break;
        // }
    }
    
    public void EjectQuarter()
    {
        _state.EjectQuarter();
        // switch (_state)
        // {
        //     case HasQuarter:
        //         Console.WriteLine("Quarter returned");
        //         _state = NoQuarter;
        //         break;
        //     case NoQuarter:
        //         Console.WriteLine("You have not inserted a quarter");
        //         break;
        //     case Sold:
        //         Console.WriteLine("Sorry, you already turned the crank");
        //         break;
        //     case SoldOut:
        //         Console.WriteLine("You can't eject, you have not inserted a quarter yet.");
        //         break;
        // }
    }
    
    public void TurnCrank()
    {
        _state.TurnCrank();
        _state.Dispense();
        // switch (_state)
        // {
        //     case Sold:
        //         Console.WriteLine("Turning twice does not get you another gumball");
        //         break;
        //     case NoQuarter:
        //         Console.WriteLine("You turned but there is no quarter");
        //         break;
        //     case SoldOut:
        //         Console.WriteLine("You turned but there are no gumballs");
        //         break;
        //     case HasQuarter:
        //         Console.WriteLine("You turned...");
        //         _state = Sold;
        //         Dispense();
        //         break;
        // }
    }
    
    // public void Dispense()
    // {
    //     switch (_state)
    //     {
    //         case Sold:
    //             Console.WriteLine("A gumball comes rolling out of the slot");
    //             _count--;
    //             if (_count == 0)
    //             {
    //                 Console.WriteLine("Oops, out of gumballs");
    //                 _state = SoldOut;
    //             }
    //             else
    //             {
    //                 _state = NoQuarter;
    //             }
    //             break;
    //         case NoQuarter:
    //             Console.WriteLine("You need to pay first");
    //             break;
    //         case SoldOut:
    //             Console.WriteLine("No gumball dispensed");
    //             break;
    //         case HasQuarter:
    //             Console.WriteLine("No gumball dispensed");
    //             break;
    //     }
    // }

    public void SetState(IState newState)
    {
        _state = newState;
    }

    public int GetCount() => _count;
    
    public void ReleaseBall()
    {
        Console.WriteLine("A gumball comes rolling out the slot");
        if (_count != 0)
        {
            _count--;
        }
    }

    public override string ToString()
    {
        return $"Gumball Machine state: {_state} --- Count : {_count}";
    }
}