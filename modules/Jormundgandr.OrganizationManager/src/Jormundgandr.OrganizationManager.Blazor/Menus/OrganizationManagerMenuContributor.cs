using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using Volo.Abp.MultiTenancy;
using Volo.Abp.UI.Navigation;
using Volo.Abp.Users;

namespace Jormundgandr.OrganizationManager.Blazor.Menus;

public class OrganizationManagerMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }

    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
 

        if(!context.ServiceProvider.GetService<ICurrentUser>().IsAuthenticated || !context.ServiceProvider.GetService<ICurrentTenant>().IsAvailable)
        {
            return Task.CompletedTask;
        }

        
        if(context.Menu.Name == StandardMenus.Main)
        {
            var menu = context.Menu.AddItem(new ApplicationMenuItem(OrganizationManagerMenus.Prefix, displayName: "OrganizationManager", "/OrganizationManager", icon: "fa fa-globe"));
            menu.AddItem(new ApplicationMenuItem("Teams", "Displayname", "/OrganizationManager/teams"));
        }

        return Task.CompletedTask;
    }
}
