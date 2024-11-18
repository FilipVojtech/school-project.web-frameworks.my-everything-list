namespace My_Everything_List;

public interface IUserService
{
    Task<string?> GetId();
    Task<string> GetEmail();
    Task<string> GetRole();
}
