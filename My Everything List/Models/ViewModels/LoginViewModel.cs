using System.ComponentModel.DataAnnotations;

namespace My_Everything_List.Models.ViewModels;

public class LoginViewModel
{
    [Required(AllowEmptyStrings = false, ErrorMessage = "Please provide an email")]
    public string? Email { get; set; }

    [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter a password")]
    public string? Password { get; set; }
}
