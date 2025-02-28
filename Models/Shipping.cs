using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Shipping
{
    [Key]
    public int Id { get; set; }

    [Required, ForeignKey("Order")]
    public int OrderId { get; set; }
    public Order Order { get; set; }

    [Required]
    public string Address { get; set; }

    public string City { get; set; }

    public string State { get; set; }

    public string Country { get; set; }

    public string PostalCode { get; set; }

    public string TrackingNumber { get; set; }

    [Required]
    public string ShippingStatus { get; set; } = "processing"; // processing, shipped, delivered

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
