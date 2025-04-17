namespace Factory;

public class NYPizzaStore : PizzaStore
{
    protected override Pizza? CreatePizza(string type)
    {
        var ingredientFactory = new NYPizzaIngredientFactory();
        Pizza? pizza = null;
        switch (type)
        {
            case "Cheese":
                pizza = new CheesePizza(ingredientFactory);
                pizza.SetName("NY Cheese Pizza");
                break;
            case "Pepperoni":
                pizza = new PepperoniPizza(ingredientFactory);
                pizza.SetName("NY Pepperoni Pizza");
                break;
            case "Clam":
                pizza = new ClamPizza(ingredientFactory);
                pizza.SetName("NY Clam Pizza");
                break;
            case "Veggies":
                pizza = new VeggiePizza(ingredientFactory);
                pizza.SetName("NY Veggie Pizza");
                break;
        }
        
        return pizza;
    }
}