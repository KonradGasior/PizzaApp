using PizzaApp.Bff.Models;

namespace PizzaApp.Bff.Services;

public class PizzaFactory : IPizzaFactory
{
    public Pizza CreateSurpriseMePizza()
    {
        return new Pizza() with
        {
           // Add randomizer
        };
    }

    public Pizza CreateCustomPizza(List<Topping> toppings, Base crustBase)
    {
        return new Pizza() with
        {
            Id = 1,
            Name = "Custom",
            Base = crustBase,
            Toppings = toppings,
            Price = 10.00M + toppings.Sum(topping => topping.Price) + crustBase.Price,
        };
    }

    public Pizza CreateMargeritha(Base crustBase)
    {
        var toppings = new List<Topping> { 
            new Topping() {
                 Id = 1,
                 Name = "",
                 Price = 0M
            }
        };
        return new Pizza() with
        {
            Id = 1,
            Name = "Custom",
            Base = crustBase,
            Toppings = new List<Topping> { },
            Price = 10.00M + toppings.Sum(topping => topping.Price) + crustBase.Price,
        };
    }
}
