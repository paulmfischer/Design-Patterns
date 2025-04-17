// See https://aka.ms/new-console-template for more information

using Factory;

var nyPizzaStore = new NYPizzaStore();
nyPizzaStore.OrderPizza("Cheese");

var chiPizzaStore = new ChicagoPizzaStore();
chiPizzaStore.OrderPizza("Cheese");
chiPizzaStore.OrderPizza("Pepperoni");
chiPizzaStore.OrderPizza("Clam");
