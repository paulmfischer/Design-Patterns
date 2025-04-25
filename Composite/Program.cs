// See https://aka.ms/new-console-template for more information

using Composite;

var pancakeHouseMenu = new Menu("Pancake House Menu", "Breakfast");
var dinerMenu = new Menu("Diner Menu", "Lunch");
var cafeMenu = new Menu("Cafe Menu", "Dinner");
var dessertMenu = new Menu("Dessert Menu", "Dessert");

var allMenus = new Menu("All Menus", "All menus combined");
allMenus.Add(pancakeHouseMenu);
allMenus.Add(dinerMenu);
allMenus.Add(cafeMenu);

dinerMenu.Add(new MenuItem("Pasta", "Spaghetti with Marinara sauce", true, 3.89));
dinerMenu.Add(dessertMenu);

dessertMenu.Add(new MenuItem("Apple Pie", "Apple pie with flaky crust topped with ice cream", true, 1.59));

pancakeHouseMenu.Add(new MenuItem("Pancake", "Your choice of toppings", true, 3.99));
cafeMenu.Add(new MenuItem("Latte", "Caffeinated beverage", true, 1.29));

allMenus.Print();
