namespace PizzaApp.Bff.Models;

public record Base
{
    public int Id { get; init; } = 0;
    public string Name { get; init; } = string.Empty;
    public int Price { get; init; } = 0;
}