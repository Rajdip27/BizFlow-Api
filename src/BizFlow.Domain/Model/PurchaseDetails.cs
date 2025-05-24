using BizFlow.Application.Model.BaseEntities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BizFlow.Domain.Model;

public class PurchaseDetails:AuditableEntity
{
    [Required]
    [ForeignKey("Purchase")]
    public long PurchaseId { get; set; }

    [Required]
    [ForeignKey("Product")]
    public long ProductId { get; set; }

    [StringLength(500)]
    public string Description { get; set; }

    [Required]
    public int Quantity { get; set; }

    [ForeignKey("Serial")]
    public int? SerialsId { get; set; } 

    [Required]
    [Column(TypeName = "decimal(18,2)")]
    public decimal Rate { get; set; }

    [Required]
    public int TaxId { get; set; }

    [Required]
    [Column(TypeName = "decimal(18,2)")]
    public decimal TaxAmount { get; set; }

    [Required]
    [Column(TypeName = "decimal(18,2)")]
    public decimal DiscountAmount { get; set; }

    [Required]
    [Column(TypeName = "decimal(18,2)")]
    public decimal TotalAmount { get; set; }

    public Purchase Purchase { get; set; }
    
    //public virtual Product Product { get; set; }
    //public virtual Serial Serials { get; set; }

}