namespace ClothesShop.Models;

public class ProductSize : BaseEntity
{
    public Size Size { get; set; }
    public int ProductId { get; set; }
    public Product Product { get; set; }
    public ICollection<ProductColor> ProductColors { get; set; }
}