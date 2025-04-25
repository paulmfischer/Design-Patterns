namespace Composite;

public class Menu(string name, string description): MenuComponent
{
    private List<MenuComponent> _menuComponents = [];

    public override void Add(MenuComponent menuComponent)
    {
        _menuComponents.Add(menuComponent);
    }

    public override void Remove(MenuComponent menuComponent)
    {
        _menuComponents.Remove(menuComponent);
    }

    public override MenuComponent GetChild(int index)
    {
        return _menuComponents[index];
    }

    public override string GetName()
    {
        return name;
    }

    public override string GetDescription()
    {
        return description;
    }

    public override void Print()
    {
        Console.Write($"\n{GetName()}");
        Console.Write($",   {GetDescription()}");
        Console.WriteLine("\n-----------------------");
        foreach (var menuComponent in _menuComponents)
        {
            menuComponent.Print();
        }
    }
}