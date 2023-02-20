using Microsoft.AspNetCore.Mvc;
using _2.Core;

namespace _4.API.Controllers;

[ApiController]
[Route("[controller]")]
public class TokenController : ControllerBase
{
    private readonly ITokenService _tokenService;
    public TokenController(ITokenService tokenService)
    {
        this._tokenService = tokenService;
    }

    [HttpGet(Name = "SendToken")]
    public async Task<string> SendEmailTokenAsync()
    {
        return await this._tokenService.SendEmailTokenAsync();
    }
}