namespace Ecommerce.Domain.Common;

public abstract class BaseDomainModel
{
    public int Id { get; set; }

//Para auditoria
    public DateTime? CreatedDate { get; set; }

//¿Quien lo creó?
    public string? CreatedBy { get; set; }

//¿Cuando se modificó por última vez?
    public DateTime? LastModifiedDate { get; set; }

//¿Quien lo modificó por última vez?
    public string? LastModifiedBy { get; set; }
}