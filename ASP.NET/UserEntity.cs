using Microsoft.AspNetCore.Identity;

public class UserEntity : IdentityUser
{
    public string FavoriteFood { get; set; }

    public UserEntity(string favoriteFood)
    {
        this.FavoriteFood = favoriteFood;
    }

    public UserEntity()
    {
        this.FavoriteFood = string.Empty;
    }
}