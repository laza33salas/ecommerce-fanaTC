using System.ComponentModel.DataAnnotations.Schema;
using Ecommerce.Domain.Common;
using Ecommerce.Domain.Enums;

namespace Ecommerce.Domain.Entities;

public class Order : BaseDomainModel
{
    public Order(){}
   
    public Order(
        string compradorNombre,
        string compradorEmail,
        OrderAdress orderAdress,
        decimal subtotal,
        decimal total,
        decimal precioEnvio
        )
    {
        CompradorNombre = compradorNombre;
        CompradorUserName= compradorEmail;
        OrderAdress = orderAdress;
        Subtotal = subtotal;
        Total = total;
        PrecioEnvio = precioEnvio;
    }

    public string? CompradorNombre { get; set; }
    public string? CompradorUserName { get; set; }
    public  OrderAdress? OrderAdress { get; set; }
    public IReadOnlyList<Order>? OrderItems { get; set; }
    
    [Column(TypeName = "decimal(10,2)")]
    public decimal Subtotal { get; set; }
    public OrderStatus status { get; set; } = OrderStatus.Pending;
     [Column(TypeName = "decimal(10,2)")]
    public decimal Total { get; set; }
     [Column(TypeName = "decimal(10,2)")]
    public decimal PrecioEnvio { get; set; }
    public string? PaymentIntentId { get; set; }
    public string? ClienteSecret { get; set; }
    public string? StripeApiKey { get; set; }
    
}

