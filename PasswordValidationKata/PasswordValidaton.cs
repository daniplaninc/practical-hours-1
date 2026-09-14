namespace PasswordValidationKata;

public class PasswordValidator
{
    public bool Validate(string password)
    {
        if (password.Length > 8)
        {
            return true;
        }

        return false;
    }
}