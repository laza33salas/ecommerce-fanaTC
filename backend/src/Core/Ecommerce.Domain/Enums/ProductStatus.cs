using System.Runtime.Serialization;

namespace Ecommerce.Domain.Enums;

public enum ProductStatus
{
    [EnumMember(Value = "Producto Activo")]
    Active,
    [EnumMember(Value = "Producto Inactivo")]
    Inactive
   
}