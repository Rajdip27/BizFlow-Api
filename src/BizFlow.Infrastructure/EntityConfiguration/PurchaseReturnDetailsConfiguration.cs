using BizFlow.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BizFlow.Infrastructure.EntityConfiguration;

public class PurchaseReturnDetailsConfiguration : IEntityTypeConfiguration<PurchaseReturnDetails>
{
    public void Configure(EntityTypeBuilder<PurchaseReturnDetails> builder)
    {
        builder.ToTable(nameof(PurchaseDetails));
        builder.HasKey(x => x.Id);
        builder.HasOne(x => x.PurchaseReturn).WithMany(x => x.PurchaseReturnDetails).HasForeignKey(x => x.PurchaseId);
    }
}