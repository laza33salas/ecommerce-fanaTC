using Ecommerce.Domain.Common;

namespace Ecommerce.Domain.Entities;

public class OrderAdress : BaseDomainModel
{
    public string? Direccion { get; set; }
    public string? Ciudad { get; set; }
    public string? Provincia { get; set; }
    public string? Username { get; set; }
    public string? Pais { get; set; }
}