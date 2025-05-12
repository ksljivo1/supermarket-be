using Microsoft.AspNetCore.Mvc;

[ApiController]
public class ProductsDetailsController : ControllerBase
{
    [Route("products/{id}")]
    [HttpGet]
    public IActionResult GetProductById()
    {
        return Ok(new {el = "jamo"});
    }
}