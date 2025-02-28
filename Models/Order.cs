using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Order
{
    [Key]
    public int Id { get; set; }

    [Required, ForeignKey("User")]
    public int UserId { get; set; }
    public User User { get; set; }

    [Required]
    public decimal TotalPrice { get; set; }

    [Required]
    public string Status { get; set; } = "pending"; // pending, shipped, delivered, cancelled

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public ICollection<OrderItem> OrderItems { get; set; }
}
