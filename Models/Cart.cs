using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Cart
{
    [Key]
    public int Id { get; set; }

    [Required, ForeignKey("User")]
    public int UserId { get; set; }
    public User User { get; set; }

    [Required, ForeignKey("Product")]
    public int ProductId { get; set; }
    public Product Product { get; set; }

    [Required]
    public int Quantity { get; set; }
}
