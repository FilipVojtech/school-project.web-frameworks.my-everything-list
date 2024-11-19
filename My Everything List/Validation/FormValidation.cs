using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace My_Everything_List.Validation;

public partial class FormValidation
{
    [GeneratedRegex("\\W")]
    private static partial Regex SpecialCharsRegex();

    [GeneratedRegex("\\d")]
    private static partial Regex DigitsRegex();

    [GeneratedRegex("[A-Z]")]
    private static partial Regex UppercaseRegex();

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class MinSpecial(int minLength) : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if (value == null)
                return false;

            var password = (string)value;
            var regex = SpecialCharsRegex();
            var match = regex.Match(password);

            return match.Captures.Count >= minLength;
        }
    }

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class MinDigits(int minLength) : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if (value == null)
                return false;

            var s = (string)value;
            var regex = DigitsRegex();
            var match = regex.Match(s);

            return match.Captures.Count >= minLength;
        }
    }

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class MinUppercase(int minLength) : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if (value == null)
                return false;

            var s = (string)value;
            var regex = UppercaseRegex();
            var match = regex.Match(s);

            return match.Captures.Count >= minLength;
        }
    }

    public class Password(
        int minSpecialCount = 1,
        int minDigitsCount = 1,
        int minUppercaseCount = 1)
        : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            List<string> errorMessages = [];

            if (value == null)
                return false;

            var result = true;
            var special = new MinSpecial(minSpecialCount);
            var digits = new MinDigits(minDigitsCount);
            var upper = new MinUppercase(minUppercaseCount);

            if (!special.IsValid(value))
            {
                errorMessages.Add(
                    $"Password must have at least {minSpecialCount} special character{(minSpecialCount > 1 ? "s" : string.Empty)}");
                result = false;
            }

            if (!digits.IsValid(value))
            {
                errorMessages.Add(
                    $"Password must have at least {minDigitsCount} digit{(minDigitsCount > 1 ? "s" : string.Empty)}");
                result = false;
            }

            if (!upper.IsValid(value))
            {
                errorMessages.Add(
                    $"Password must have at least {minUppercaseCount} uppercase letter{(minUppercaseCount > 1 ? "s" : string.Empty)}");
                result = false;
            }

            if (errorMessages.Count == 0)
            {
                return result;
            }

            var errorMessage = string.Empty;
            foreach (var message in errorMessages)
            {
                errorMessage += $"{message}<br/>";
            }

            ErrorMessage = errorMessage[..^5];
            return result;
        }
    }
}
