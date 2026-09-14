namespace PasswordValidationKata.Tests;

public class IterationOne
{
    [Fact]
    public void AcceptPasswordWithMoreThanEightCharacters()
    {
        string longPassword = "hdv_bg6stf.DUSFB";
        var passwordValidator = new PasswordValidator();
        
        Assert.True(passwordValidator.Validate(longPassword));
    }
    
    [Fact]
    public void RejectPasswordWithLessThanEightCharacters()
    {
        string shortPassword = "v_bf.DU";
        var passwordValidator = new PasswordValidator();
        
        Assert.False(passwordValidator.Validate(shortPassword));
    }
    
    [Fact]
    public void AcceptPasswordWithCapitalLetters()
    {
        string longPassword = "hdv_bg6stf.DUSFB";
        var passwordValidator = new PasswordValidator();
        
        Assert.True(passwordValidator.Validate(longPassword));
    }
    
    [Fact]
    public void RejectPasswordWithoutCapitalLetters()
    {
        string longPassword = "hdv_bg6stf.dusfb";
        var passwordValidator = new PasswordValidator();
        
        Assert.False(passwordValidator.Validate(longPassword));
    }
    
    [Fact]
    public void AcceptPasswordWithLowercaseLetters()
    {
        string longPassword = "hdv_bg6stf.DUSFB";
        var passwordValidator = new PasswordValidator();
        
        Assert.True(passwordValidator.Validate(longPassword));
    }
    
    [Fact]
    public void RejectPasswordWithoutLowercaseLetters()
    {
        string longPassword = "HDV_BG6STF.DUSFB";
        var passwordValidator = new PasswordValidator();
        
        Assert.False(passwordValidator.Validate(longPassword));
    }
    
    [Fact]
    public void AcceptPasswordWithNumbers()
    {
        string longPassword = "hdv_bg6stf.DUSFB";
        var passwordValidator = new PasswordValidator();
        
        Assert.True(passwordValidator.Validate(longPassword));
    }
    
    [Fact]
    public void RejectPasswordWithoutNumbers()
    {
        string longPassword = "HDV_BGhSTF.DUSFB";
        var passwordValidator = new PasswordValidator();
        
        Assert.False(passwordValidator.Validate(longPassword));
    }
    
    [Fact]
    public void AcceptPasswordWithUnderscores()
    {
        string longPassword = "hdv_bg6stf.DUSFB";
        var passwordValidator = new PasswordValidator();
        
        Assert.True(passwordValidator.Validate(longPassword));
    }
    
    [Fact]
    public void RejectPasswordWithoutUnderscores()
    {
        string longPassword = "hdvbg6stf.DUSFB";
        var passwordValidator = new PasswordValidator();
        
        Assert.False(passwordValidator.Validate(longPassword));
    }
}