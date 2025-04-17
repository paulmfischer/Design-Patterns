namespace Factory;

public class ChicagoPizzaStore : PizzaStore
{
    protected override Pizza? CreatePizza(string type)
    {
        var ingredientFactory = new NYPizzaIngredientFactory();
        Pizza? pizza = null;
        switch (type)
        {
            case "Cheese":
                pizza = new CheesePizza(ingredientFactory);
                pizza.SetName("Chicago Cheese Pizza");
                break;
            case "Pepperoni":
                pizza = new PepperoniPizza(ingredientFactory);
                pizza.SetName("Chicago Pepperoni Pizza");
                break;
            case "Clam":
                pizza = new ClamPizza(ingredientFactory);
                pizza.SetName("Chicago Clam Pizza");
                break;
            case "Veggies":
                pizza = new VeggiePizza(ingredientFactory);
                pizza.SetName("Chicago Veggie Pizza");
                break;
        }
        
        return pizza;
    }
    
}