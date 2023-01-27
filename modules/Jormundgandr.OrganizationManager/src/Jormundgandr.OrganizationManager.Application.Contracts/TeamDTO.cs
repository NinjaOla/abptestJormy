using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Auditing;

namespace Jormundgandr.OrganizationManager
{
    public class TeamDTO:EntityDto<Guid>,IMustHaveCreator
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid CreatorId { get; }
    }
    public class CreateUpdateTeamDTO:EntityDto<Guid>,IMustHaveCreator
    {
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }
        public Guid CreatorId { get; }
    }
}
