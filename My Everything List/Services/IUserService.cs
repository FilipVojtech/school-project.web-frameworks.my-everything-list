namespace My_Everything_List;

public interface IUserService
{
    Task<int?> GetId();
    Task<string?> GetEmail();
    Task<string?> GetRole();
}
