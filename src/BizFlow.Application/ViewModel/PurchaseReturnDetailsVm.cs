using System.ComponentModel.DataAnnotations;
using BizFlow.Application.Model.BaseEntities;

namespace BizFlow.Application.ViewModel;

public class PurchaseReturnDetailsVm:BaseEntity
{
    [Required]
    [Display(Name = "Purchase Return ID")]
    public int PurchaseId { get; set; }

    [Required]
    [Display(Name = "Product")]
    public int ProductId { get; set; }

    [Display(Name = "Description")]
    [StringLength(500)]
    public string Description { get; set; }

    [Required(ErrorMessage = "Quantity is required")]
    [Range(1, int.MaxValue, ErrorMessage = "Quantity must be at least 1")]
    public int Quantity { get; set; }

    [Display(Name = "Serial ID")]
    public int? SerialsId { get; set; }

    [Required]
    [Display(Name = "Rate")]
    [DataType(DataType.Currency)]
    public decimal Rate { get; set; }

    [Required]
    [Display(Name = "Tax")]
    public int TaxId { get; set; }

    [Required]
    [Display(Name = "Tax Amount")]
    [DataType(DataType.Currency)]
    public decimal TaxAmount { get; set; }

    [Required]
    [Display(Name = "Discount Amount")]
    [DataType(DataType.Currency)]
    public decimal DiscountAmount { get; set; }

    [Required]
    [Display(Name = "Total Amount")]
    [DataType(DataType.Currency)]
    public decimal TotalAmount { get; set; }
}