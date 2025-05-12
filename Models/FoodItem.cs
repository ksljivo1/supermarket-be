using System.ComponentModel.DataAnnotations.Schema;

namespace Test.Api.Models;

[Table("food_items")]
public class FoodItem
{
    public int id { get; set; }
    public string name { get; set; }
    public double price { get; set; }
    public string description { get; set; }
    public string price_id { get; set; }
    public string image { get; set; }
    public string storage { get; set; }
    
    [Column("category_id")]
    public int CategoryId { get; set; }
    
    public Category Category { get; set; } // navigation property
}