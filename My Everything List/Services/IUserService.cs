using My_Everything_List.Models;

namespace My_Everything_List;

public interface IUserService
{
    Task<User?> GetUser();
    Task<int?> GetId();
    Task<string?> GetEmail();
    Task<string?> GetRole();
}
