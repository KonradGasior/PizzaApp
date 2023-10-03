namespace PizzaApp.Bff.Models;

public record Pizza
{
    // All of it should be populated from the db
    public int Id { get; init; } = 0;
    public string Name { get; init; } = string.Empty;
    public List<Topping> Toppings { get; init; } = new List<Topping>();
    public Base Base { get; init; } = new Base();
    public decimal Price { get; init; } = 0M;
}