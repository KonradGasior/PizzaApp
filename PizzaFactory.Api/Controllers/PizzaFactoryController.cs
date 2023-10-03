using Microsoft.AspNetCore.Mvc;
using PizzaApp.Bff.Models;
using PizzaApp.Bff.Services;

namespace PizzaApp.Bff.Controllers;

[ApiController]
[Route("api")]
public class PizzaFactoryController : ControllerBase
{
    private readonly ILogger<PizzaFactoryController> _logger;
    private readonly IPizzaFactory _pizzaFactory = new PizzaFactory();

    public PizzaFactoryController(ILogger<PizzaFactoryController> logger)
    {
        _logger = logger;
    }

    [HttpGet("GetPizza")]
    public ActionResult<Pizza> Get()
    {
        return Ok(_pizzaFactory.CreateCustomPizza());
    }
}