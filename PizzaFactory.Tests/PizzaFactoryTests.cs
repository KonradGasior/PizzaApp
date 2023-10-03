using Xunit;
using NSubstitute;
using PizzaApp.Bff.Services;
using FluentAssertions;
using AutoFixture;
using PizzaApp.Bff.Models;

namespace PizzaApp.Bff.Tests;

public class PizzaFactoryTests
{
    private readonly Fixture _fixture = new();
    private readonly IPizzaFactory _pizzaFactory = Substitute.For<IPizzaFactory>();


    [Fact]
    public void CreateSurpriseMePizza_ResultShouldNotBeNull()
    {
        var result = _pizzaFactory.CreateSurpriseMePizza();
        result.Should().NotBeNull();
    }

    [Fact]
    public void PizzaFactory_ResultShouldNotBeNull()
    {
        var toppings = new List<Topping>
        {
            _fixture.Create<Topping>(),
            _fixture.Create<Topping>(),
            _fixture.Create<Topping>()
        };
        var crustBase = _fixture.Create<Base>();
        var result = _pizzaFactory.CreateCustomPizza(toppings, crustBase);
        result.Should().NotBeNull();
    }
}