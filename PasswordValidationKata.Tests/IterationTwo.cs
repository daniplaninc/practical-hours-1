namespace PasswordValidationKata.Tests;

public class IterationTwo
{
    private readonly Dictionary<string, object> _validationTwoRules = new Dictionary<string, object>
    {
        { "min_length", 6 },
        { "requireUpper", true },
        { "requireLower", true },
        { "requireNumber", true },
    };
    
    private readonly Dictionary<string, object> _validationTwoPasswords = new Dictionary<string, object>
    {
        {"ValidPassword", "hdvbg6stf.DUSFB" },
        {"ShortPassword", "vb.DB" },
        {"LowerPassword", "hdvbg6stf.dusfb" },
        {"UpperPassword", "HDVBG6STF.DUSFB" },
        {"NumberlessPassword", "hdvbgstf.DUSFB" },
    };
    
    private readonly Dictionary<string, object> _validationThreeRules = new Dictionary<string, object>
    {
        { "min_length", 16 },
        { "requireUpper", true },
        { "requireLower", true },
        { "requireUnderscore", true },
    };
    
    private readonly Dictionary<string, object> _validationThreePasswords = new Dictionary<string, object>
    {
        {"ValidPassword", "hdvbg_stf.DUSFBhdvbg_stf.DUSFB" },
        {"ShortPassword", "vb.D_B" },
        {"LowerPassword", "hdvbg_stf.dusfbhdvbg_stf.dusfb" },
        {"UpperPassword", "HDVBG_STF.DUSFBHDVBG_STF.DUSFB" },
        {"UnderscorelessPassword", "hdvbgstf.DUSFBhdvbgstf.DUSFB" },
    };
    
    [Fact]
    public void ValidationTwo_AcceptPasswordWithMoreThanSixCharacters()
    {
        var passwordValidator = new PasswordValidator(_validationTwoRules);
        
        Assert.True(passwordValidator.Validate((string)_validationTwoPasswords["ValidPassword"]));
    }
    
    [Fact]
    public void ValidationTwo_RejectPasswordWithLessThanSixCharacters()
    {
        var passwordValidator = new PasswordValidator(_validationTwoRules);
        
        Assert.False(passwordValidator.Validate((string)_validationTwoPasswords["ShortPassword"]));
    }
    
    [Fact]
    public void ValidationTwo_AcceptPasswordWithCapitalLetters()
    {
        var passwordValidator = new PasswordValidator(_validationTwoRules);
        
        Assert.True(passwordValidator.Validate((string)_validationTwoPasswords["ValidPassword"]));
    }
    
    [Fact]
    public void ValidationTwo_RejectPasswordWithoutCapitalLetters()
    {
        var passwordValidator = new PasswordValidator(_validationTwoRules);
        
        Assert.False(passwordValidator.Validate((string)_validationTwoPasswords["LowerPassword"]));
    }
    
    [Fact]
    public void ValidationTwo_AcceptPasswordWithLowercaseLetters()
    {
        var passwordValidator = new PasswordValidator(_validationTwoRules);
        
        Assert.True(passwordValidator.Validate((string)_validationTwoPasswords["ValidPassword"]));
    }
    
    [Fact]
    public void ValidationTwo_RejectPasswordWithoutLowercaseLetters()
    {
        var passwordValidator = new PasswordValidator(_validationTwoRules);
        
        Assert.False(passwordValidator.Validate((string)_validationTwoPasswords["UpperPassword"]));
    }
    
    [Fact]
    public void ValidationTwo_AcceptPasswordWithNumbers()
    {
        var passwordValidator = new PasswordValidator(_validationTwoRules);
        
        Assert.True(passwordValidator.Validate((string)_validationTwoPasswords["ValidPassword"]));
    }
    
    [Fact]
    public void ValidationTwo_RejectPasswordWithoutNumbers()
    {
        var passwordValidator = new PasswordValidator(_validationTwoRules);
        
        Assert.False(passwordValidator.Validate((string)_validationTwoPasswords["NumberlessPassword"]));
    }
    
    [Fact]
    public void ValidationThree_AcceptPasswordWithMoreThanEightCharacters()
    {
        var passwordValidator = new PasswordValidator(_validationThreeRules);
        
        Assert.True(passwordValidator.Validate((string)_validationThreePasswords["ValidPassword"]));
    }
    
    [Fact]
    public void ValidationThree_RejectPasswordWithLessThanEightCharacters()
    {
        var passwordValidator = new PasswordValidator(_validationThreeRules);
        
        Assert.False(passwordValidator.Validate((string)_validationThreePasswords["ShortPassword"]));
    }
    
    [Fact]
    public void ValidationThree_AcceptPasswordWithCapitalLetters()
    {
        var passwordValidator = new PasswordValidator(_validationThreeRules);
        
        Assert.True(passwordValidator.Validate((string)_validationThreePasswords["ValidPassword"]));
    }
    
    [Fact]
    public void ValidationThree_RejectPasswordWithoutCapitalLetters()
    {
        var passwordValidator = new PasswordValidator(_validationThreeRules);
        
        Assert.False(passwordValidator.Validate((string)_validationThreePasswords["LowerPassword"]));
    }
    
    [Fact]
    public void ValidationThree_AcceptPasswordWithLowercaseLetters()
    {
        var passwordValidator = new PasswordValidator(_validationThreeRules);
        
        Assert.True(passwordValidator.Validate((string)_validationThreePasswords["ValidPassword"]));
    }
    
    [Fact]
    public void ValidationThree_RejectPasswordWithoutLowercaseLetters()
    {
        var passwordValidator = new PasswordValidator(_validationThreeRules);
        
        Assert.False(passwordValidator.Validate((string)_validationThreePasswords["UpperPassword"]));
    }
    
    [Fact]
    public void ValidationThree_AcceptPasswordWithUnderscores()
    {
        var passwordValidator = new PasswordValidator(_validationThreeRules);
        
        Assert.True(passwordValidator.Validate((string)_validationThreePasswords["ValidPassword"]));
    }
    
    [Fact]
    public void ValidationThree_RejectPasswordWithoutUnderscores()
    {
        var passwordValidator = new PasswordValidator(_validationThreeRules);
        
        Assert.False(passwordValidator.Validate((string)_validationThreePasswords["UnderscorelessPassword"]));
    }
}