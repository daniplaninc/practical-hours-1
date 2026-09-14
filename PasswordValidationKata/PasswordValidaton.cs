namespace PasswordValidationKata;

public class PasswordValidator
{
    public bool Validate(string password)
    {
        if (password.Length > 8)
        {
            if (password.Any(char.IsUpper))
            {
                return true;
            }
        }

        return false;
    }
}