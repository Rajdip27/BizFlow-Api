using BizFlow.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BizFlow.Infrastructure.EntityConfiguration;

public class PurchaseReturnConfiguration: IEntityTypeConfiguration<PurchaseReturn>
{
    public void Configure(EntityTypeBuilder<PurchaseReturn> builder)
    {
        builder.ToTable(nameof(PurchaseReturn));
        builder.HasKey(x => x.Id);
    }
}