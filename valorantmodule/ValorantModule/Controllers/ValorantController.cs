using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using ValorantModule.Models;
using ValorantModule.Services;

namespace ValorantModule.Controllers;

[ApiController]
[Route("[controller]")]
public class ValorantController : ControllerBase
{
    private PlayerService playerService;

    public ValorantController()
    {
        playerService = new PlayerService();
    }

    [HttpGet("GetBaseInformation")]
    public async Task<BasicInformation> GetBaseInformation()
    {
        return playerService.GetBaseInformation().Result;
    }
}

