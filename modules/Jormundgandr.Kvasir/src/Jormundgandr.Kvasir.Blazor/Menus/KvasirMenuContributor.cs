using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace Jormundgandr.Kvasir.Blazor.Menus;

public class KvasirMenuContributor : IMenuContributor
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
        //Add main menu items.
        context.Menu.AddItem(new ApplicationMenuItem(KvasirMenus.Prefix, displayName: "Kvasir", "/Kvasir", icon: "fa fa-globe"));

        return Task.CompletedTask;
    }
}
