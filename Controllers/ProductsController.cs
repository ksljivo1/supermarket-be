using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Test.Api.Context;

namespace Test.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public ProductsController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var itemsWithCategoryNames = await _context.FoodItems
            .Include(f => f.Category) // Optional here, but keeps eager loading
            .Select(f => new 
            {
                f.id,
                f.name,
                f.price,
                f.description,
                f.price_id,
                f.image,
                f.storage,
                f.CategoryId,
                CategoryName = f.Category.name
            })
            .ToListAsync();

        return Ok(itemsWithCategoryNames);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetProduct(int id)
    {
        var productWithId = await _context.FoodItems.Where(f => f.id.Equals(id))
            .Select(f => new 
            {
                f.id,
                f.name,
                f.price,
                f.description,
                f.price_id,
                f.image,
                f.storage,
                f.CategoryId,
                CategoryName = f.Category.name
            }).FirstOrDefaultAsync();
        return Ok(productWithId);
    }
}
