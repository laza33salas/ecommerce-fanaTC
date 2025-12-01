using System.Runtime.Serialization;

namespace Ecommerce.Domain.Enums;

public enum OrderStatus
{
    [EnumMember(Value = "Pendiente")]
    Pending,
     [EnumMember(Value = "El pago fue recibido con exito")]
    Completed,
     [EnumMember(Value = "El producto fue enviado")]
    Enviado,
     [EnumMember(Value = "El pago tuvo errores")]
    Error
}