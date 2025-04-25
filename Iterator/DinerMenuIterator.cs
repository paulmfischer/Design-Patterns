namespace Iterator;

public class DinerMenuIterator : IIterator
{
    private readonly MenuItem[] _items;
    private int _position = 0;

    public DinerMenuIterator(MenuItem[] items)
    {
        _items = items;
    }

    public bool HasNext()
    {
        return _position < _items.Length && _items[_position] != null;
    }

    public object Next()
    {
        var menuItem =  _items[_position];
        _position++;
        return menuItem;
    }
}