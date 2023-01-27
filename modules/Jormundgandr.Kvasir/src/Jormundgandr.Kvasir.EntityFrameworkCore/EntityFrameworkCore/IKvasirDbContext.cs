using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Jormundgandr.Kvasir.EntityFrameworkCore;

[ConnectionStringName(KvasirDbProperties.ConnectionStringName)]
public interface IKvasirDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
