using BizFlow.Application.Model.BaseEntities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BizFlow.Domain.Model;

public class Purchase:AuditableEntity
{
    [Required]
    [StringLength(50)]
    public string InvoiceNo { get; set; }

    [Required]
    public long SupplierId { get; set; }

    [Required]
    public long EmployeeId { get; set; }

    [Required]
    [Column(TypeName = "decimal(18,2)")]
    public decimal SubTotalAmount { get; set; }

    [Required]
    [Column(TypeName = "decimal(18,2)")]
    public decimal DiscountAmount { get; set; }

    [Required]
    public int TaxRateId { get; set; }

    [Required]
    [Column(TypeName = "decimal(18,2)")]
    public decimal TaxAmount { get; set; }

    [Required]
    [Column(TypeName = "decimal(18,2)")]
    public decimal PaidAmount { get; set; }

    [Required]
    [Column(TypeName = "decimal(18,2)")]
    public decimal DueAmount { get; set; }

    [Required]
    [StringLength(20)]
    public string DeliveryStatus { get; set; } // e.g., "Pending", "Delivered"

    [Required]
    [Column(TypeName = "decimal(18,2)")]
    public decimal TotalAmount { get; set; }

    [StringLength(500)]
    public string Note { get; set; }

    [Required]
    [StringLength(20)]
    public string Status { get; set; } // e.g., "Completed", "Pending"

    [StringLength(50)]
    public string PoNo { get; set; }

    [Required]
    public DateTimeOffset PurchaseDate { get; set; }

    [StringLength(100)]
    public string PurchaseTransactionId { get; set; }

    [Required]
    [StringLength(20)]
    public string PaymentType { get; set; } // e.g., "Cash", "Card", "UPI"

    public ICollection<PurchaseDetails> PurchaseDetails { get; set; }=new List<PurchaseDetails>();
    public ICollection<PurchaseTransaction> PurchaseTransaction { get; set; }=new List<PurchaseTransaction>();
}