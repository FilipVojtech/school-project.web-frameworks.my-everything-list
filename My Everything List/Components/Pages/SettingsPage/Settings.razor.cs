namespace My_Everything_List.Components.Pages.SettingsPage;

public partial class Settings
{
    private int? _id;

    private string? _email;

    private string? _role;

    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        _id = await UserService.GetId();
        _email = await UserService.GetEmail();
        _role = await UserService.GetRole();
    }

    public void DeleteAccount()
    {
        Console.Out.WriteLine("Account Deleted");
    }
}
