namespace PasswordValidationKata;

public class PasswordValidator(Dictionary<string, object> rules)
{
        /* Example rules array
            var rules = new Dictionary<string, object>
            {
                { "min_length", 8 },
                { "requireUpper", true },
                { "requireLower", true },
                { "requireNumber", true },
                { "requireUnderscore", true }
            };
         */
    
    public bool Validate(string password)
    {
        if (rules.TryGetValue("min_length", out var lengthValue) && lengthValue is int minLength)
        {
            if (password.Length < minLength)
            {
                return false;
            }
        }
        
        if (rules.TryGetValue("requireUpper", out var requireUpper) && requireUpper is bool)
        {
            if (!password.Any(char.IsUpper))
            {
                return false;
            }
        }
        
        if (rules.TryGetValue("requireLower", out var requireLower) && requireLower is bool)
        {
            if (!password.Any(char.IsLower))
            {
                return false;
            }
        }
        
        if (rules.TryGetValue("requireNumber", out var requireNumber) && requireLower is bool)
        {
            if (!password.Any(char.IsNumber))
            {
                return false;
            }
        }
        
        if (rules.TryGetValue("requireUnderscore", out var requireUnderscore) && requireUnderscore is bool)
        {
            if (!password.Contains('_'))
            {
                return false;
            }
        }

        return true;
    }
}