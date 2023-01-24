using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NuvToolsBlazorTemplate.Application.WeatherForecasts.Queries;
using NuvToolsBlazorTemplate.WebUI.Shared.WeatherForecasts;

namespace NuvToolsBlazorTemplate.WebUI.Server.Controllers;

[Authorize]
public class WeatherForecastController : ApiControllerBase
{
    [HttpGet]
    public async Task<IList<WeatherForecast>> Get()
    {
        return await Mediator.Send(new GetWeatherForecastsQuery());
    }
}
