using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Volo.Abp;

namespace Jormundgandr.OrganizationManager
{

    //[Area(OrganizationManagerRemoteServiceConsts.ModuleName)]
    //[RemoteService(Name = OrganizationManagerRemoteServiceConsts.RemoteServiceName)]
    //public class TeamsController : OrganizationManagerController, ITeamAppService
    //{
    //    private readonly ITeamAppService _teamAppService;

    //    public TeamsController(ITeamAppService teamAppService)
    //    {
    //        _teamAppService = teamAppService;
    //    }

    //    [HttpPost]
    //    public async Task<TeamDTO> CreateAsync(TeamDTO input)
    //    {
    //        return await _teamAppService.CreateAsync(input);
    //    }

    //    [HttpDelete]
    //    public async Task<bool> DeleteAsync(Guid id)
    //    {
    //        return await _teamAppService.DeleteAsync(id);
    //    }

    //    [HttpGet]
    //    public async Task<TeamDTO> GetAsync(Guid id)
    //    {
    //        return await _teamAppService.GetAsync(id);
    //    }

    //    [HttpGet]
    //    public async Task<List<TeamDTO>> GetListAsync()
    //    {
    //        return await _teamAppService.GetListAsync();
    //    }

    //    [HttpPut]
    //    public Task<TeamDTO> UpdateAsync(TeamDTO input)
    //    {
    //        return _teamAppService.UpdateAsync(input);
    //    }
    //}
}
