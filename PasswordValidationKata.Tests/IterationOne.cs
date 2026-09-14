namespace PasswordValidationKata.Tests;

public class IterationOne
{
    [Fact]
    public void AcceptPasswordWithMoreThanEightCharacters()
    {
        string longPassword = "hdvfbg6stf.DUSFB";
        var passwordValidator = new PasswordValidator();
        
        Assert.True(passwordValidator.Validate(longPassword));
    }
    
    [Fact]
    public void RejectPasswordWithLessThanEightCharacters()
    {
        string shortPassword = "vfbf.DU";
        var passwordValidator = new PasswordValidator();
        
        Assert.False(passwordValidator.Validate(shortPassword));
    }
    
    [Fact]
    public void AcceptPasswordWithCapitalLetters()
    {
        string longPassword = "hdvfbg6stf.DUSFB";
        var passwordValidator = new PasswordValidator();
        
        Assert.True(passwordValidator.Validate(longPassword));
    }
    
    [Fact]
    public void RejectPasswordWithoutCapitalLetters()
    {
        string longPassword = "hdvfbg6stf.dusfb";
        var passwordValidator = new PasswordValidator();
        
        Assert.False(passwordValidator.Validate(longPassword));
    }
    
    [Fact]
    public void AcceptPasswordWithLowercaseLetters()
    {
        string longPassword = "hdvfbg6stf.DUSFB";
        var passwordValidator = new PasswordValidator();
        
        Assert.True(passwordValidator.Validate(longPassword));
    }
    
    [Fact]
    public void RejectPasswordWithoutLowercaseLetters()
    {
        string longPassword = "HDVFBG6STF.DUSFB";
        var passwordValidator = new PasswordValidator();
        
        Assert.False(passwordValidator.Validate(longPassword));
    }
}