using Microsoft.AspNetCore.Mvc;

namespace ShippingCostApi.Controllers;
[ApiController]
[Route("[controller]")]
public class ShippingCostController : ControllerBase
{
    private readonly ILogger<ShippingCostController> _logger;

    public ShippingCostController(ILogger<ShippingCostController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetShippingCost")]
    public decimal Get()
    {
        return 0;
    }
}
