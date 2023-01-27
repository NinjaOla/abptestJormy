using Jormundgandr.OrganizationManager.Entities;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Jormundgandr.OrganizationManager.EntityFrameworkCore;

public static class OrganizationManagerDbContextModelCreatingExtensions
{
    public static void ConfigureOrganizationManager(
        this ModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));


        builder.Entity<Team>(t =>
        {
            t.ToTable(OrganizationManagerDbProperties.DbTablePrefix + nameof(OrganizationManagerDbContext.Teams), OrganizationManagerDbProperties.DbSchema);
            t.ConfigureByConvention();
        });

        /* Configure all entities here. Example:

        builder.Entity<Question>(b =>
        {
            //Configure table & schema name
            b.ToTable(OrganizationManagerDbProperties.DbTablePrefix + "Questions", OrganizationManagerDbProperties.DbSchema);

            b.ConfigureByConvention();

            //Properties
            b.Property(q => q.Title).IsRequired().HasMaxLength(QuestionConsts.MaxTitleLength);

            //Relations
            b.HasMany(question => question.Tags).WithOne().HasForeignKey(qt => qt.QuestionId);

            //Indexes
            b.HasIndex(q => q.CreationTime);
        });
        */
    }
}
