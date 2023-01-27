using Volo.Abp.Settings;

namespace AbpJormundgandr.Settings;

public class AbpJormundgandrSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(AbpJormundgandrSettings.MySetting1));
    }
}
