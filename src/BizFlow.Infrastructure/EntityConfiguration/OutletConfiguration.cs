using BizFlow.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace BizFlow.Infrastructure.EntityConfiguration;
public class OutletConfiguration: IEntityTypeConfiguration<Outlet>
{
    public void Configure(EntityTypeBuilder<Outlet> builder)
    {
        builder.ToTable(nameof(Outlet));
        builder.HasKey(x => x.Id);
    }
}