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
                    if (password.Any(char.IsNumber))
                    {
                        if (password.Contains('_'))
                        {
                            return true;
                        }
                    }
                }
            }
        }

        return false;
    }
}