using Jormundgandr.OrganizationManager.Entities;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Jormundgandr.OrganizationManager.EntityFrameworkCore;

[ConnectionStringName(OrganizationManagerDbProperties.ConnectionStringName)]
public class OrganizationManagerDbContext : AbpDbContext<OrganizationManagerDbContext>, IOrganizationManagerDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */
    public DbSet<Team> Teams { get; set; }
    public OrganizationManagerDbContext(DbContextOptions<OrganizationManagerDbContext> options)
        : base(options)
    {

    }

    

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureOrganizationManager();
    }
}
