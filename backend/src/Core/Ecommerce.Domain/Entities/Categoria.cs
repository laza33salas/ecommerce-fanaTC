using System.ComponentModel.DataAnnotations.Schema;
using Ecommerce.Domain.Common;

namespace Ecommerce.Domain.Entites;


    public class Category : BaseDomainModel
    {
        [Column(TypeName = "nvarchar(100)")]
        public string? Name { get; set; }
    }