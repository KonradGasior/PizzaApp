namespace PizzaApp.Bff.Models;

public record Topping
{
    public int Id { get; init; } = 0;
    public string Name { get; init; } = string.Empty;
    public decimal Price { get; init; } = 0M;
}