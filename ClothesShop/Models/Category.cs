namespace ClothesShop.Models;

public class Category : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string Image { get; set; }
    public Guid? ParentId { get; set; }
    public ICollection<Product> Products { get; set; }
}