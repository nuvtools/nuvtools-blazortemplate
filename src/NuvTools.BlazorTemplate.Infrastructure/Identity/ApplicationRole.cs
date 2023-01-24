using Microsoft.AspNetCore.Identity;
using NuvToolsBlazorTemplate.WebUI.Shared.Authorization;

namespace NuvToolsBlazorTemplate.Infrastructure.Identity;

public class ApplicationRole : IdentityRole
{
    public Permissions Permissions { get; set; }
}
