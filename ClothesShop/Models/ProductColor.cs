namespace ClothesShop.Models;

public class ProductColor : BaseEntity
{
    public Color Color { get; set; }
    public ProductSize ProductSize { get; set; }
    public Guid ProductSizeId { get; set; }
    public int Quantity { get; set; }
}