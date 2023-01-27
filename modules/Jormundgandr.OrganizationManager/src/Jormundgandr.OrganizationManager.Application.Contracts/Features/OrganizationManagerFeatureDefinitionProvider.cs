using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Features;

namespace Jormundgandr.OrganizationManager.Features
{
    //Requires nuget : Volo.Abp.Features
    public class OrganizationManagerFeatureDefinitionProvider : FeatureDefinitionProvider
    {
        public override void Define(IFeatureDefinitionContext context)
        {
            var myGroup = context.AddGroup("OrganizationManager");
            myGroup.AddFeature("OrganizationManager.Teams", defaultValue: "false");
        }
    }
}
