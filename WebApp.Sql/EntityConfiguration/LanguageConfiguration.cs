using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Sql.Entities.Enrols;

namespace WebApp.Sql.EntityConfiguration
{
    internal class LanguageConfiguration : IEntityTypeConfiguration<Language>
    {
        public void Configure(EntityTypeBuilder<Language> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(p => p.Proficiency).WithMany(t => t.Languages).HasForeignKey(f => f.ProficencyId);
            builder.HasOne(p => p.Employees).WithMany(t => t.Languages).HasForeignKey(f => f.EmployeeId);
        }
    }
}
