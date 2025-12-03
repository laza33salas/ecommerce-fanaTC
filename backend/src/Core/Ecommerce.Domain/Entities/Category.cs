using System.ComponentModel.DataAnnotations.Schema;
using Ecommerce.Domain.Common;

namespace Ecommerce.Domain.Entities;


    public class Category : BaseDomainModel
    {
        [Column(TypeName = "nvarchar(100)")]
        public string? Name { get; set; }
    }