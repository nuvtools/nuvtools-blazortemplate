using Microsoft.AspNetCore.Mvc;
using NuvToolsBlazorTemplate.Application.AccessControl.Commands;
using NuvToolsBlazorTemplate.Application.AccessControl.Queries;
using NuvToolsBlazorTemplate.WebUI.Client.Shared;
using NuvToolsBlazorTemplate.WebUI.Shared.AccessControl;
using NuvToolsBlazorTemplate.WebUI.Shared.Authorization;

namespace NuvToolsBlazorTemplate.WebUI.Server.Controllers.Admin;

[Route("api/Admin/[controller]")]
public class AccessControlController : ApiControllerBase
{
    [HttpGet]
    [Authorize(Permissions.ViewAccessControl)]
    public async Task<ActionResult<AccessControlVm>> GetConfiguration()
    {
        return await Mediator.Send(new GetAccessControlQuery());
    }

    [HttpPut]
    [Authorize(Permissions.ConfigureAccessControl)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public async Task<IActionResult> UpdateConfiguration(RoleDto updatedRole)
    {
        await Mediator.Send(new UpdateAccessControlCommand(updatedRole.Id, updatedRole.Permissions));

        return NoContent();
    }
}
