namespace PasswordValidationKata.Tests;

public class IterationOne
{
    private const string ValidPassword = "hdv_bg6stf.DUSFB";
    private const string ShortPassword = "v_b.DUB";
    private const string LowerPassword = "hdv_bg6stf.dusfb";
    private const string UpperPassword = "HDV_BG6STF.DUSFB";
    private const string NumberlessPassword = "hdv_bgstf.DUSFB";
    private const string UnderscorelessPassword = "hdvbg6stf.DUSFB";
    
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
    
    private readonly Dictionary<string, object> _validationTwoRules = new Dictionary<string, object>
    {
        { "min_length", 6 },
        { "requireUpper", true },
        { "requireLower", true },
        { "requireNumber", true },
    };
    
    private readonly Dictionary<string, object> _validationThreeRules = new Dictionary<string, object>
    {
        { "min_length", 16 },
        { "requireUpper", true },
        { "requireLower", true },
        { "requireUnderscore", true },
    };
    
    [Fact]
    public void AcceptPasswordWithMoreThanEightCharacters()
    {
        var passwordValidator = new PasswordValidator(_validationOneRules);
        
        Assert.True(passwordValidator.Validate((string)_validationOnePasswords["ValidPassword"]));
    }
    
    [Fact]
    public void RejectPasswordWithLessThanEightCharacters()
    {
        var passwordValidator = new PasswordValidator(_validationOneRules);
        
        Assert.False(passwordValidator.Validate((string)_validationOnePasswords["ShortPassword"]));
    }
    
    [Fact]
    public void AcceptPasswordWithCapitalLetters()
    {
        var passwordValidator = new PasswordValidator(_validationOneRules);
        
        Assert.True(passwordValidator.Validate((string)_validationOnePasswords["ValidPassword"]));
    }
    
    [Fact]
    public void RejectPasswordWithoutCapitalLetters()
    {
        var passwordValidator = new PasswordValidator(_validationOneRules);
        
        Assert.False(passwordValidator.Validate((string)_validationOnePasswords["LowerPassword"]));
    }
    
    [Fact]
    public void AcceptPasswordWithLowercaseLetters()
    {
        var passwordValidator = new PasswordValidator(_validationOneRules);
        
        Assert.True(passwordValidator.Validate((string)_validationOnePasswords["ValidPassword"]));
    }
    
    [Fact]
    public void RejectPasswordWithoutLowercaseLetters()
    {
        var passwordValidator = new PasswordValidator(_validationOneRules);
        
        Assert.False(passwordValidator.Validate((string)_validationOnePasswords["UpperPassword"]));
    }
    
    [Fact]
    public void AcceptPasswordWithNumbers()
    {
        var passwordValidator = new PasswordValidator(_validationOneRules);
        
        Assert.True(passwordValidator.Validate((string)_validationOnePasswords["ValidPassword"]));
    }
    
    [Fact]
    public void RejectPasswordWithoutNumbers()
    {
        var passwordValidator = new PasswordValidator(_validationOneRules);
        
        Assert.False(passwordValidator.Validate((string)_validationOnePasswords["NumberlessPassword"]));
    }
    
    [Fact]
    public void AcceptPasswordWithUnderscores()
    {
        var passwordValidator = new PasswordValidator(_validationOneRules);
        
        Assert.True(passwordValidator.Validate((string)_validationOnePasswords["ValidPassword"]));
    }
    
    [Fact]
    public void RejectPasswordWithoutUnderscores()
    {
        var passwordValidator = new PasswordValidator(_validationOneRules);
        
        Assert.False(passwordValidator.Validate((string)_validationOnePasswords["UnderscorelessPassword"]));
    }
}