namespace PasswordValidationKata.Tests;

public class IterationOne
{
    
    private readonly Dictionary<string, object> _validationOneRules = new Dictionary<string, object>
    {
        { "min_length", 8 },
        { "requireUpper", true },
        { "requireLower", true },
        { "requireNumber", true },
        { "requireUnderscore", true }
    };
    
    private readonly Dictionary<string, object> _validationOnePasswords = new Dictionary<string, object>
    {
        {"ValidPassword", "hdv_bg6stf.DUSFB" },
        {"ShortPassword", "v_b.DUB" },
        {"LowerPassword", "hdv_bg6stf.dusfb" },
        {"UpperPassword", "HDV_BG6STF.DUSFB" },
        {"NumberlessPassword", "hdv_bgstf.DUSFB" },
        {"UnderscorelessPassword", "hdvbg6stf.DUSFB" },
    };
    
    [Fact]
    public void ValidationOne_AcceptPasswordWithMoreThanEightCharacters()
    {
        var passwordValidator = new PasswordValidator(_validationOneRules);
        
        Assert.True(passwordValidator.Validate((string)_validationOnePasswords["ValidPassword"]));
    }
    
    [Fact]
    public void ValidationOne_RejectPasswordWithLessThanEightCharacters()
    {
        var passwordValidator = new PasswordValidator(_validationOneRules);
        
        Assert.False(passwordValidator.Validate((string)_validationOnePasswords["ShortPassword"]));
    }
    
    [Fact]
    public void ValidationOne_AcceptPasswordWithCapitalLetters()
    {
        var passwordValidator = new PasswordValidator(_validationOneRules);
        
        Assert.True(passwordValidator.Validate((string)_validationOnePasswords["ValidPassword"]));
    }
    
    [Fact]
    public void ValidationOne_RejectPasswordWithoutCapitalLetters()
    {
        var passwordValidator = new PasswordValidator(_validationOneRules);
        
        Assert.False(passwordValidator.Validate((string)_validationOnePasswords["LowerPassword"]));
    }
    
    [Fact]
    public void ValidationOne_AcceptPasswordWithLowercaseLetters()
    {
        var passwordValidator = new PasswordValidator(_validationOneRules);
        
        Assert.True(passwordValidator.Validate((string)_validationOnePasswords["ValidPassword"]));
    }
    
    [Fact]
    public void ValidationOne_RejectPasswordWithoutLowercaseLetters()
    {
        var passwordValidator = new PasswordValidator(_validationOneRules);
        
        Assert.False(passwordValidator.Validate((string)_validationOnePasswords["UpperPassword"]));
    }
    
    [Fact]
    public void ValidationOne_AcceptPasswordWithNumbers()
    {
        var passwordValidator = new PasswordValidator(_validationOneRules);
        
        Assert.True(passwordValidator.Validate((string)_validationOnePasswords["ValidPassword"]));
    }
    
    [Fact]
    public void ValidationOne_RejectPasswordWithoutNumbers()
    {
        var passwordValidator = new PasswordValidator(_validationOneRules);
        
        Assert.False(passwordValidator.Validate((string)_validationOnePasswords["NumberlessPassword"]));
    }
    
    [Fact]
    public void ValidationOne_AcceptPasswordWithUnderscores()
    {
        var passwordValidator = new PasswordValidator(_validationOneRules);
        
        Assert.True(passwordValidator.Validate((string)_validationOnePasswords["ValidPassword"]));
    }
    
    [Fact]
    public void ValidationOne_RejectPasswordWithoutUnderscores()
    {
        var passwordValidator = new PasswordValidator(_validationOneRules);
        
        Assert.False(passwordValidator.Validate((string)_validationOnePasswords["UnderscorelessPassword"]));
    }
}