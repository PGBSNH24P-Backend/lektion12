using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("test")]
public class TestController : ControllerBase
{
    private readonly AppDbContext context;
    private readonly UserManager<UserEntity> userManager;

    public TestController(
        AppDbContext context,
        UserManager<UserEntity> userManager
    )
    {
        this.context = context;
        this.userManager = userManager;
    }

    [HttpGet("first")]
    [Authorize]
    public IActionResult SecuredEndpoint()
    {
        foreach (var claim in User.Claims)
        {
            Console.WriteLine(claim.ToString());
        }

        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        if (userId == null)
        {
            return Unauthorized();
        }

        var user = context.Users.Find(userId);
        if (user == null)
        {
            return Unauthorized();
        }

        return Ok("Hello " + user.UserName + "!");
    }

    [HttpPost("register-user")]
    public async Task<IActionResult> RegisterUser([FromBody] RegisterUserRequest request)
    {
        var userEntity = new UserEntity(request.FavoriteFood);
        userEntity.UserName = request.UserName;

        IdentityResult result = await userManager.CreateAsync(userEntity, request.Password);
        if (!result.Succeeded)
        {
            return BadRequest(result.Errors);
        }

        return Ok();
    }
}

public class RegisterUserRequest
{
    public required string UserName { get; set; }
    public required string Password { get; set; }
    public required string FavoriteFood { get; set; }
}