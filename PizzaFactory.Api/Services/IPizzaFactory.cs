using PizzaApp.Bff.Models;

namespace PizzaApp.Bff.Services;

public interface IPizzaFactory
{
    public Pizza CreateSurpriseMePizza();
    public Pizza CreateCustomPizza(List<Topping> toppings, Base crustBase);
    public Pizza CreateMargeritha(Base crustBase);
}
