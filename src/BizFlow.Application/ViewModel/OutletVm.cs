using BizFlow.Application.Model.BaseEntities;
using System.ComponentModel.DataAnnotations;
using AutoMapper;
using BizFlow.Domain.Model;
namespace BizFlow.Application.ViewModel;
[AutoMap(typeof(Outlet), ReverseMap = true)]
public class OutletVm: BaseEntity
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