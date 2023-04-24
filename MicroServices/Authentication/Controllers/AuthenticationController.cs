using Microsoft.AspNetCore.Mvc;
using StockPortfolioTracker.Common;
using StockPortfolioTracker.Logic;

namespace Authentication.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthenticationController : ControllerBase
{
    #region Fields
    private readonly IAuthenticationService? authenticationService;
    #endregion

    #region Constructors
    public AuthenticationController(IAuthenticationService authenticationService)
    {
        this.authenticationService = authenticationService;
    }
    #endregion

    #region Publics
    [HttpPost]
    [Route("RegisterUser")]
    public async Task<BaseApiResponseDto> RegisterUser([FromBody] UserRegisterDto userRegisterDto)
    {
        BaseApiResponseDto response = await this.authenticationService!.RegisterUser(userRegisterDto);

        return response;
    }

    [HttpPost]
    [Route("LoginUser")]
    public async Task<BaseApiResponseDto> LoginUser([FromBody] UserLoginDto userLoginDto)
    {
        BaseApiResponseDto response = await this.authenticationService!.LoginUser(userLoginDto);

        return response;
    }
    #endregion
}