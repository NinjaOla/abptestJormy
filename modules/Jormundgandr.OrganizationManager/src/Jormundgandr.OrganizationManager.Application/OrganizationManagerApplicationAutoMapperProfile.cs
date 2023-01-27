using AutoMapper;
using Jormundgandr.OrganizationManager.Entities;

namespace Jormundgandr.OrganizationManager;

public class OrganizationManagerApplicationAutoMapperProfile : Profile
{
    public OrganizationManagerApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<TeamDTO, Team>();
        CreateMap<Team, TeamDTO>();
        CreateMap<CreateUpdateTeamDTO, TeamDTO>();
        CreateMap<CreateUpdateTeamDTO, Team>();
    }
}
