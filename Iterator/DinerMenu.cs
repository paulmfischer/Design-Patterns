namespace Iterator;

public class DinerMenu
{
    private const int MaxItems = 4;
    private int _numberOfItems = 0;
    private readonly MenuItem[] _menuItems;

    public DinerMenu()
    {
        _menuItems = new MenuItem[MaxItems];
        
        AddItem("Vegetarian BLT", "(Fakin') Bacon with lettuce and tomato on whole wheat", true, 2.99);
        AddItem("BLT", "Bacon with lettuce and tomato on whole wheat", false, 2.99);
        AddItem("Soup of the day", "Soup of the day, with a side of potato salad", false, 3.29);
        AddItem("Hotdog", "Hot dog with saurkraut, relish, onions and topped with cheese", true, 3.05);
    }

    private void AddItem(string name, string description, bool vegetarian, double price)
    {
        var menuItem = new MenuItem(name, description, vegetarian, price);
        if (_numberOfItems >= MaxItems)
        {
            Console.WriteLine("Sorry, menu is full!");
        }
        else
        {
            _menuItems[_numberOfItems] = menuItem;
            _numberOfItems++;
        }
    }
    
    public MenuItem[] GetMenuItems() => _menuItems;

    public IIterator CreateIterator()
    {
        return new DinerMenuIterator(_menuItems);
    }
}