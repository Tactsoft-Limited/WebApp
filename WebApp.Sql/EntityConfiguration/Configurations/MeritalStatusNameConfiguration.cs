using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApp.Sql.Entities.Configurations;

namespace WebApp.Sql.EntityConfiguration.Configurations
{
    public class MeritalStatusNameConfiguration : IEntityTypeConfiguration<MeritalStatus>
    {
        public void Configure(EntityTypeBuilder<MeritalStatus> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
