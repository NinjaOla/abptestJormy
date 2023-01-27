using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Jormundgandr.OrganizationManager
{
    [RemoteService(Name = "Teams", IsEnabled = true, IsMetadataEnabled = true)]
    public interface ITeamAppService : ICrudAppService<TeamDTO, Guid, PagedAndSortedResultRequestDto, CreateUpdateTeamDTO>
    {
    }
}
