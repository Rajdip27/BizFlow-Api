using BizFlow.Application.Model.BaseEntities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BizFlow.Domain.Model;

public class PurchaseTransaction:AuditableEntity
{
    [Required]
    [ForeignKey("Purchase")]
    public long PurchaseId { get; set; }

    [ForeignKey("PurchaseReturn")]
    public long PurchaseReturnId { get; set; } // Optional: A transaction may relate to a return

    [Required]
    [Column(TypeName = "decimal(18,2)")]
    public decimal Amount { get; set; }

    [Required]
    [StringLength(50)]
    public string PaymentType { get; set; } // e.g., Cash, Card, UPI, Bank Transfer

    // Navigation Properties (Optional)
    public  Purchase Purchase { get; set; }
    public  PurchaseReturn PurchaseReturn { get; set; }
}