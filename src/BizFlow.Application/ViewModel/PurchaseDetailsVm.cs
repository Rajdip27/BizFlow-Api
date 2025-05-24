using BizFlow.Application.Model.BaseEntities;
using System.ComponentModel.DataAnnotations;

namespace BizFlow.Application.ViewModel;

public class PurchaseDetailsVm:BaseEntity
{
    [Required(ErrorMessage = "Purchase is required")]
    [Display(Name = "Purchase")]
    public long PurchaseId { get; set; }

    [Required(ErrorMessage = "Product is required")]
    [Display(Name = "Product")]
    public long ProductId { get; set; }

    [Display(Name = "Description")]
    [StringLength(500)]
    public string Description { get; set; }

    [Required(ErrorMessage = "Quantity is required")]
    [Range(1, int.MaxValue, ErrorMessage = "Quantity must be at least 1")]
    public int Quantity { get; set; }

    [Display(Name = "Serial ID")]
    public long? SerialsId { get; set; }

    [Required(ErrorMessage = "Rate is required")]
    [DataType(DataType.Currency)]
    public decimal Rate { get; set; }

    [Required(ErrorMessage = "Tax is required")]
    public long TaxId { get; set; }

    [Required(ErrorMessage = "Tax amount is required")]
    [DataType(DataType.Currency)]
    public decimal TaxAmount { get; set; }

    [Required(ErrorMessage = "Discount is required")]
    [DataType(DataType.Currency)]
    public decimal DiscountAmount { get; set; }

    [Required(ErrorMessage = "Total amount is required")]
    [DataType(DataType.Currency)]
    public decimal TotalAmount { get; set; }
}