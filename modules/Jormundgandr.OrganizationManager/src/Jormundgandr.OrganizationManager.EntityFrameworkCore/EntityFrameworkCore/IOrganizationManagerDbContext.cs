using Jormundgandr.OrganizationManager.Entities;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Jormundgandr.OrganizationManager.EntityFrameworkCore;

[ConnectionStringName(OrganizationManagerDbProperties.ConnectionStringName)]
public interface IOrganizationManagerDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
    DbSet<Team> Teams { get; set; }
}
