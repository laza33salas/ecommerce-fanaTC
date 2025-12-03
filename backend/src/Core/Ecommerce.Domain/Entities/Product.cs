using System.ComponentModel.DataAnnotations.Schema;
using Ecommerce.Domain.Common;
using Ecommerce.Domain.Enums;

namespace Ecommerce.Domain.Entities;

public class Product : BaseDomainModel
{
    [Column(TypeName = "nvarchar(100)")]
    public string? Nombre { get; set; }
   
    [Column(TypeName = "decimal(10,2)")]
    public decimal Precio { get; set; }
    
     [Column(TypeName = "decimal(10,2)")]
    public decimal PrecioTransferencia { get; set; }
   
    [Column(TypeName = "nvarchar(100)")]
    public string? Fabricante { get; set; }
    
    [Column(TypeName = "nvarchar(4000)")]
    public string? Descripcion { get; set; }
    
    public ProductStatus Status { get; set; } = ProductStatus.Active;
    public int Rating { get; set; }
    public string? Material { get; set; }
    public string? Medidas { get; set; }
    public int Stock { get; set; }
    public int CategoriaId { get; set; }

    public virtual Category? Category { get; set; }
}
