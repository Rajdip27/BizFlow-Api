using AutoMapper;
using BizFlow.Application.Model.BaseEntities;
using BizFlow.Domain.Model;
using System.ComponentModel.DataAnnotations;

namespace BizFlow.Application.ViewModel;
[AutoMap(typeof(PurchaseTransaction), ReverseMap = true)]

public class PurchaseTransactionVm:BaseEntity
{
    [Required(ErrorMessage = "Purchase ID is required")]
    [Display(Name = "Purchase ID")]
    public long PurchaseId { get; set; }

    [Display(Name = "Purchase Return ID")]
    public long PurchaseReturnId { get; set; } // Nullable

    [Required(ErrorMessage = "Amount is required")]
    [Display(Name = "Amount")]
    [DataType(DataType.Currency)]
    public decimal Amount { get; set; }

    [Required(ErrorMessage = "Payment type is required")]
    [Display(Name = "Payment Type")]
    public string PaymentType { get; set; } // Could be converted to an enum or dropdown
}