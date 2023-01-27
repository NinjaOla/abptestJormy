using Jormundgandr.OrganizationManager.Entities;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Jormundgandr.OrganizationManager.EntityFrameworkCore;

[DependsOn(
    typeof(OrganizationManagerDomainModule),
    typeof(AbpEntityFrameworkCoreModule)
)]
public class OrganizationManagerEntityFrameworkCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<OrganizationManagerDbContext>(options =>
        {
            options.AddDefaultRepositories(includeAllEntities:true);
            //options.AddRepository<OMTeam, IOrganizationManagerDbContext>();
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, EfCoreQuestionRepository>();
                 */
        });
    }
}
