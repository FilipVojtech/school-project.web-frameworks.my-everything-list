using Microsoft.AspNetCore.Components.Authorization;
using My_Everything_List.Models;

namespace My_Everything_List;

public class UserService : IUserService
{
    private readonly AuthenticationStateProvider _asp;

    public UserService(AuthenticationStateProvider asp)
    {
        _asp = asp;
    }

    // TODO: Ask how to make this a property (ie. without async)
    public async Task<User?> GetUser()
    {
        return new User
        {
            Id = await GetId() ?? -1,
            Email = await GetEmail(),
            Role = await GetRole(),
        };
    }

    public async Task<int?> GetId()
    {
        var user = (await _asp.GetAuthenticationStateAsync()).User;
        var userId = user.FindFirst(u => u.Type.Contains("nameidentifier"))?.Value;

        if (int.TryParse(userId, out var id))
        {
            return id;
        }

        return null;
    }

    public async Task<string?> GetEmail()
    {
        var user = (await _asp.GetAuthenticationStateAsync()).User;
        var email = user.FindFirst(u => u.Type.Contains("email"))?.Value;
        return email;
    }

    public async Task<string?> GetRole()
    {
        var user = (await _asp.GetAuthenticationStateAsync()).User;
        var role = user.FindFirst(u => u.Type.Contains("role"))?.Value;
        return role;
    }
}
