namespace PasswordValidationKata;

public class PasswordValidator
{
    public bool Validate(string password)
    {
        if (password.Length > 8)
        {
            if (password.Any(char.IsUpper))
            {
                if (password.Any(char.IsLower))
                {
                    return true;
                }
            }
        }

        return false;
    }
}