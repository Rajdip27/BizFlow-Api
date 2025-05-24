using BizFlow.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BizFlow.Infrastructure.EntityConfiguration;

public class PurchaseDetailsConfiguration: IEntityTypeConfiguration<PurchaseDetails>
{
    public void Configure(EntityTypeBuilder<PurchaseDetails> builder)
    {
        builder.ToTable(nameof(PurchaseDetails));
        builder.HasKey(x => x.Id);
        builder.HasOne(x => x.Purchase).WithMany(x => x.PurchaseDetails).HasForeignKey(x => x.PurchaseId);
    }
}