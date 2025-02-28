using System;
using System.ComponentModel.DataAnnotations;

public class Category
{
    [Key]
    public int id { get; set; }

    public string name { get; set; }

    public string description { get; set; }

    public DateTime created_at { get; set; } = DateTime.UtcNow;

    public ICollection<Product> Products { get; set; } = [];
}
