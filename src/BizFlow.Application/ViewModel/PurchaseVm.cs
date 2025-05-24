using System.ComponentModel.DataAnnotations;
using AutoMapper;
using BizFlow.Application.Model.BaseEntities;
using BizFlow.Domain.Model;

namespace BizFlow.Application.ViewModel;
[AutoMap(typeof(Purchase), ReverseMap = true)]

public class PurchaseVm:BaseEntity
{

    [Required(ErrorMessage = "Invoice number is required")]
    [Display(Name = "Invoice No")]
    public string InvoiceNo { get; set; }

    [Required(ErrorMessage = "Supplier is required")]
    [Display(Name = "Supplier")]
    public int SupplierId { get; set; }

    [Required(ErrorMessage = "Employee is required")]
    [Display(Name = "Employee")]
    public int EmployeeId { get; set; }

    [Required(ErrorMessage = "Subtotal is required")]
    [Display(Name = "Subtotal Amount")]
    [DataType(DataType.Currency)]
    public decimal SubTotalAmount { get; set; }

    [Required(ErrorMessage = "Discount is required")]
    [Display(Name = "Discount Amount")]
    [DataType(DataType.Currency)]
    public decimal DiscountAmount { get; set; }

    [Required(ErrorMessage = "Tax rate is required")]
    [Display(Name = "Tax Rate ID")]
    public int TaxRateId { get; set; }

    [Required(ErrorMessage = "Tax amount is required")]
    [Display(Name = "Tax Amount")]
    [DataType(DataType.Currency)]
    public decimal TaxAmount { get; set; }

    [Required(ErrorMessage = "Paid amount is required")]
    [Display(Name = "Paid Amount")]
    [DataType(DataType.Currency)]
    public decimal PaidAmount { get; set; }

    [Required(ErrorMessage = "Due amount is required")]
    [Display(Name = "Due Amount")]
    [DataType(DataType.Currency)]
    public decimal DueAmount { get; set; }

    [Required(ErrorMessage = "Delivery status is required")]
    [Display(Name = "Delivery Status")]
    public string DeliveryStatus { get; set; }

    [Required(ErrorMessage = "Total amount is required")]
    [Display(Name = "Total Amount")]
    [DataType(DataType.Currency)]
    public decimal TotalAmount { get; set; }

    [Display(Name = "Note")]
    [DataType(DataType.MultilineText)]
    public string Note { get; set; }

    [Required(ErrorMessage = "Status is required")]
    [Display(Name = "Status")]
    public string Status { get; set; }

    [Display(Name = "PO No")]
    public string PoNo { get; set; }

    [Required(ErrorMessage = "Purchase date is required")]
    [Display(Name = "Purchase Date")]
    [DataType(DataType.Date)]
    public DateTime PurchaseDate { get; set; }

    [Display(Name = "Transaction ID")]
    public string PurchaseTransactionId { get; set; }

    [Required(ErrorMessage = "Payment type is required")]
    [Display(Name = "Payment Type")]
    public string PaymentType { get; set; }
}