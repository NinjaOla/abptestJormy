using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Jormundgandr.Kvasir.EntityFrameworkCore;

[ConnectionStringName(KvasirDbProperties.ConnectionStringName)]
public class KvasirDbContext : AbpDbContext<KvasirDbContext>, IKvasirDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public KvasirDbContext(DbContextOptions<KvasirDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureKvasir();
    }
}
