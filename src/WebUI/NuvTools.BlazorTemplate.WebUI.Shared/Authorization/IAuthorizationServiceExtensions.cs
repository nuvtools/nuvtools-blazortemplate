using Microsoft.AspNetCore.Authorization;
using NuvToolsBlazorTemplate.WebUI.Shared.Authorization;
using System.Security.Claims;

namespace NuvToolsBlazorTemplate.WebUI.Shared.Authorization;

public static class IAuthorizationServiceExtensions
{
    public static Task<AuthorizationResult> AuthorizeAsync(this IAuthorizationService service, ClaimsPrincipal user, Permissions permissions)
    {
        return service.AuthorizeAsync(user, PolicyNameHelper.GeneratePolicyNameFor(permissions));
    }
}
