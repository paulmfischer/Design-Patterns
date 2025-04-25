// See https://aka.ms/new-console-template for more information

using Iterator;

var pancakeMenu = new PancakeHouseMenu();
var dinerMenu = new DinerMenu();

// before IIterator code changes
var breakfastItems = pancakeMenu.GetMenuItems();
var lunchItems = dinerMenu.GetMenuItems();

// dotnet already has this pattern implemented so we can just use foreach on either implementation
// but for the sake of the exercise we will still create the iterator pattern.
// including the foreach snippets but commented out

// foreach (var menuItem in breakfastItems)
// {
//     Console.WriteLine($"{menuItem.Name} - {menuItem.Description} - {menuItem.Price}");
// }
for (var i = 0; i < breakfastItems.Count; i++)
{
    var menuItem = breakfastItems.ElementAt(i);
    Console.WriteLine($"{menuItem.Name} - {menuItem.Description} - {menuItem.Price}");
}

// foreach (var menuItem in lunchItems)
// {
//     Console.WriteLine($"{menuItem.Name} - {menuItem.Description} - {menuItem.Price}");
// }
for (var i = 0; i < lunchItems.Length; i++)
{
    var menuItem = lunchItems[i];
    Console.WriteLine($"{menuItem.Name} - {menuItem.Description} - {menuItem.Price}");
}

// after IIterator code changes
var breakfastIterator = pancakeMenu.CreateIterator();
var lunchIterator = dinerMenu.CreateIterator();

Console.WriteLine("---------- IIterator menu items -----------");
PrintMenu(breakfastIterator);
PrintMenu(lunchIterator);
return;

void PrintMenu(IIterator iterator)
{
    while (iterator.HasNext())
    {
        var menuItem = (MenuItem)iterator.Next();
        Console.WriteLine($"{menuItem.Name} - {menuItem.Description} - {menuItem.Price}");
    }
}
