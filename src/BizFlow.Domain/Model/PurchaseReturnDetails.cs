using BizFlow.Application.Model.BaseEntities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BizFlow.Domain.Model;

public class PurchaseReturnDetails:AuditableEntity
{
    [Required]
    [ForeignKey("PurchaseReturn")]
    public long PurchaseReturnId { get; set; }

    [Required]
    [ForeignKey("Product")]
    public long ProductId { get; set; }

    [StringLength(500)]
    public string Description { get; set; }

    [Required]
    [Range(1, int.MaxValue)]
    public int Quantity { get; set; }

    [ForeignKey("Serial")]
    public long SerialsId { get; set; }

    [Required]
    [Column(TypeName = "decimal(18,2)")]
    public decimal Rate { get; set; }

    [Required]
    public long TaxId { get; set; }

    [Required]
    [Column(TypeName = "decimal(18,2)")]
    public decimal TaxAmount { get; set; }

    [Required]
    [Column(TypeName = "decimal(18,2)")]
    public decimal DiscountAmount { get; set; }

    [Required]
    [Column(TypeName = "decimal(18,2)")]
    public decimal TotalAmount { get; set; }

    // Navigation Properties (Optional)
    public  PurchaseReturn PurchaseReturn { get; set; }
    //public virtual Product Product { get; set; }
    //public virtual Serial Serials { get; set; }
}