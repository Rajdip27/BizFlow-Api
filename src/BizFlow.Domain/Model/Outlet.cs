using BizFlow.Application.Model.BaseEntities;
using System.ComponentModel.DataAnnotations;

namespace BizFlow.Domain.Model;

public class Outlet: AuditableEntity
{
    [Required]
    [StringLength(100)]
    public string Name { get; set; }

    [Phone]
    public string Phone { get; set; }

    [StringLength(200)]
    public string Address { get; set; }

    [StringLength(50)]
    public string City { get; set; }

    [StringLength(50)]
    public string Country { get; set; }

    [Url]
    public string Website { get; set; }
}