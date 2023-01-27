using Jormundgandr.OrganizationManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Jormundgandr.OrganizationManager
{
    public class TeamAppService : CrudAppService<Team,TeamDTO,Guid,PagedAndSortedResultRequestDto,CreateUpdateTeamDTO>, ITeamAppService
    {

        public TeamAppService(IRepository<Team, Guid> teamRepository) : base(teamRepository) { }


    }
}
