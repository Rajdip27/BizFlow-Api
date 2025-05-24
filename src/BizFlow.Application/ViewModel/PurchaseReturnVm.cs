using System.ComponentModel.DataAnnotations;
using AutoMapper;
using BizFlow.Application.Model.BaseEntities;
using BizFlow.Domain.Model;

namespace BizFlow.Application.ViewModel;
[AutoMap(typeof(PurchaseReturn), ReverseMap = true)]

public class PurchaseReturnVm:BaseEntity
{
    [Required(ErrorMessage = "Invoice No is required")]
    [Display(Name = "Invoice No")]
    public string InvoiceNo { get; set; }

    [Required(ErrorMessage = "Supplier is required")]
    [Display(Name = "Supplier")]
    public long SupplierId { get; set; }

    [Required(ErrorMessage = "Employee is required")]
    [Display(Name = "Employee")]
    public long EmployeeId { get; set; }

    [Required]
    [Display(Name = "Subtotal Amount")]
    [DataType(DataType.Currency)]
    public decimal SubTotalAmount { get; set; }

    [Required]
    [Display(Name = "Discount Amount")]
    [DataType(DataType.Currency)]
    public decimal DiscountAmount { get; set; }

    [Required]
    [Display(Name = "Tax Rate")]
    public long TaxRateId { get; set; }

    [Required]
    [Display(Name = "Tax Amount")]
    [DataType(DataType.Currency)]
    public decimal TaxAmount { get; set; }

    [Required]
    [Display(Name = "Paid Amount")]
    [DataType(DataType.Currency)]
    public decimal PaidAmount { get; set; }

    [Required]
    [Display(Name = "Due Amount")]
    [DataType(DataType.Currency)]
    public decimal DueAmount { get; set; }

    [Required]
    [Display(Name = "Delivery Status")]
    public string DeliveryStatus { get; set; }

    [Required]
    [Display(Name = "Total Amount")]
    [DataType(DataType.Currency)]
    public decimal TotalAmount { get; set; }

    [Display(Name = "Note")]
    public string Note { get; set; }

    [Required]
    [Display(Name = "Status")]
    public string Status { get; set; }

    [Display(Name = "PO No")]
    public string PoNo { get; set; }

    [Required]
    [Display(Name = "Purchase Date")]
    [DataType(DataType.Date)]
    public DateTime PurchaseDate { get; set; }

    [Display(Name = "Purchase Transaction")]
    public string PurchaseTransaction { get; set; }
}