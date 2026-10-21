namespace PasswordValidation;

public static class PasswordValidator
{
    public static bool IsValid(string? password)
    {
        if (string.IsNullOrWhiteSpace(password))
        {
            return false;
        }

        if (password.Length < 8)
        {
            return false;
        }

        bool hasDigit = password.Any(char.IsDigit);
        bool hasLatinLetter = password.Any(c =>
            (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'));

        return hasDigit && hasLatinLetter;
    }
}
