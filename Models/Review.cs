using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Review
{
    [Key]
    public int Id { get; set; }

    [Required, ForeignKey("User")]
    public int UserId { get; set; }
    public User User { get; set; }

    [Required, ForeignKey("Product")]
    public int ProductId { get; set; }
    public Product Product { get; set; }

    [Required, Range(1, 5)]
    public int Rating { get; set; }

    public string Comment { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
