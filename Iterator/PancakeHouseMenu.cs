namespace Iterator;

public class PancakeHouseMenu
{
    private readonly List<MenuItem> _menuItems;

    public PancakeHouseMenu()
    {
        _menuItems = new List<MenuItem>();

        AddItem("K&B's Pancake Breakfast", "Pancakes with scrambled eggs and toast", true, 2.99);
        AddItem("Regular Pancake Breakfast", "Pancakes with fried eggs and sausage", false, 2.99);
        AddItem("Blueberry Pancakes", "Pancakes with fresh blueberries", true, 3.49);
        AddItem("Waffles", "Waffles with your choice of blueberries or strawberries", true, 3.59);
    }

    private void AddItem(string name, string description, bool vegetarian, double price)
    {
        _menuItems.Add(new MenuItem(name, description, vegetarian, price));
    }
    
    public List<MenuItem> GetMenuItems() => _menuItems;
    
    public IIterator CreateIterator()
    {
        return new DinerMenuIterator(_menuItems.ToArray());
    }
}