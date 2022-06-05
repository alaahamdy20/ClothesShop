namespace ClothesShop.Models;

public class Product: BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string ImageUrl { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    public ICollection<ProductImage> ProductImages { get; set; }
    public ICollection<ProductSize> ProductSizes { get; set; }
}