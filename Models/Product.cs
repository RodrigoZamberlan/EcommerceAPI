using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Product
{
    [Key]
    public int id { get; set; }

    [Required, MaxLength(100)]
    public string name { get; set; }

    public string description { get; set; }

    [Required]
    public decimal price { get; set; }

    [Required]
    public int stock_quantity { get; set; } = 0;

    public string image_url { get; set; }

    [ForeignKey("Category"), Required]
    public int? category_id { get; set; }
    public Category? Category { get; set; }

    public DateTime created_at { get; set; } = DateTime.UtcNow;
}
