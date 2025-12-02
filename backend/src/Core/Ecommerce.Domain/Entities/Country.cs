using System.ComponentModel.DataAnnotations.Schema;
using Ecommerce.Domain.Common;
namespace Ecommerce.Domain.Entities;

public class Country : BaseDomainModel
{
    [Column (TypeName = "nvarchar(100)")]
    public string? Nombre { get; set; }
    public string? Iso2 { get; set; }
    public string? Iso3 { get; set; }
}