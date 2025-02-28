using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Payment
{
    [Key]
    public int Id { get; set; }

    [Required, ForeignKey("Order")]
    public int OrderId { get; set; }
    public Order Order { get; set; }

    [Required]
    public string PaymentMethod { get; set; }

    [Required]
    public string PaymentStatus { get; set; } = "pending"; // pending, completed, failed

    public string TransactionId { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
