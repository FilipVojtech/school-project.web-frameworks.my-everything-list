using System.ComponentModel.DataAnnotations;
using static My_Everything_List.Validation.FormValidation;

namespace My_Everything_List.Models.ViewModels;

public class RegisterViewModel
{
    [Required(AllowEmptyStrings = false, ErrorMessage = "Please provide an email")]
    public string? Email { get; set; }

    [Required(AllowEmptyStrings = false, ErrorMessage = "Please provide a password")]
    [MinLength(10, ErrorMessage = "Password must be at least 10 characters long")]
    [Password]
    public string? Password { get; set; }
}
