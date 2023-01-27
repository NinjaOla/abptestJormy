using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;
using Volo.Abp.MultiTenancy;

namespace Jormundgandr.OrganizationManager.Entities
{
    public class Team : Entity<Guid>, IMultiTenant, IMustHaveCreator
    {
        public Guid? TenantId { get; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid CreatorId { get; }
    }
}
