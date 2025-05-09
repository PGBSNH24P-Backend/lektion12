using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services
            .AddDbContext<AppDbContext>(options =>
                options.UseNpgsql("Host=localhost;Port=5432;Username=postgres;Password=password;Database=lektion12")
            );

        builder.Services.AddControllers();
        builder.Services.AddAuthentication()
            .AddBearerToken(IdentityConstants.BearerScheme);
        builder.Services.AddAuthorization();

        builder.Services.AddIdentityCore<UserEntity>()
            .AddEntityFrameworkStores<AppDbContext>()
            .AddApiEndpoints();

        var app = builder.Build();

        app.UseHttpsRedirection();

        app.MapIdentityApi<UserEntity>();
        app.MapControllers();

        app.UseAuthentication();
        app.UseAuthorization();

        app.Run();
    }
}
