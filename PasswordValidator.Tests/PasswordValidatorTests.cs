namespace PasswordValidator.Tests;

using PasswordValidation;

public class PasswordValidatorTests
{
    // Позитивные тесты: пароль содержит не менее 8 символов, цифру и латинскую букву.
    [Theory]
    [InlineData("Password1")]
    [InlineData("Abcdef12")]
    [InlineData("z9q7v3x4")]
    public void IsValid_ReturnsTrue_ForValidPasswords(string password)
    {
        Assert.True(PasswordValidation.PasswordValidator.IsValid(password));
    }

    // Негативные тесты: проверяются пароли, не соответствующие правилам задания;круто
    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData(" ")]
    [InlineData("short1")]
    [InlineData("abcdefgh")]
    [InlineData("12345678")]
    [InlineData("password")]
    [InlineData("Qwertyui")]
    [InlineData("Пароль123")]
    public void IsValid_ReturnsFalse_ForInvalidPasswords(string? password)
    {
        Assert.False(PasswordValidation.PasswordValidator.IsValid(password));
    }
}
