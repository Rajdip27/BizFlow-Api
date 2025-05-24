using BizFlow.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BizFlow.Infrastructure.EntityConfiguration;

public class PurchaseTransactionConfiguration:IEntityTypeConfiguration<PurchaseTransaction>
{
    public void Configure(EntityTypeBuilder<PurchaseTransaction> builder)
    {
        builder.ToTable(nameof(PurchaseTransaction));
        builder.HasKey(x => x.Id);
        builder.HasOne(x => x.Purchase).WithMany(x => x.PurchaseTransaction).HasForeignKey(x => x.PurchaseId);
        builder.HasOne(x => x.PurchaseReturn).WithMany(x => x.PurchaseTransactions).HasForeignKey(x => x.PurchaseReturnId);
    }
}