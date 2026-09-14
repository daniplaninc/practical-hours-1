namespace PasswordValidationKata.Tests;

public class IterationOne
{
    private const string ValidPassword = "hdv_bg6stf.DUSFB";
    private const string ShortPassword = "v_b.DUB";
    private const string LowerPassword = "hdv_bg6stf.dusfb";
    private const string UpperPassword = "HDV_BG6STF.DUSFB";
    private const string NumberlessPassword = "hdv_bgstf.DUSFB";
    private const string UnderscorelessPassword = "hdvbg6stf.DUSFB";
    
    [Fact]
    public void AcceptPasswordWithMoreThanEightCharacters()
    {
        var passwordValidator = new PasswordValidator();
        
        Assert.True(passwordValidator.Validate(ValidPassword));
    }
    
    [Fact]
    public void RejectPasswordWithLessThanEightCharacters()
    {
        var passwordValidator = new PasswordValidator();
        
        Assert.False(passwordValidator.Validate(ShortPassword));
    }
    
    [Fact]
    public void AcceptPasswordWithCapitalLetters()
    {
        var passwordValidator = new PasswordValidator();
        
        Assert.True(passwordValidator.Validate(ValidPassword));
    }
    
    [Fact]
    public void RejectPasswordWithoutCapitalLetters()
    {
        var passwordValidator = new PasswordValidator();
        
        Assert.False(passwordValidator.Validate(LowerPassword));
    }
    
    [Fact]
    public void AcceptPasswordWithLowercaseLetters()
    {
        var passwordValidator = new PasswordValidator();
        
        Assert.True(passwordValidator.Validate(ValidPassword));
    }
    
    [Fact]
    public void RejectPasswordWithoutLowercaseLetters()
    {
        var passwordValidator = new PasswordValidator();
        
        Assert.False(passwordValidator.Validate(UpperPassword));
    }
    
    [Fact]
    public void AcceptPasswordWithNumbers()
    {
        var passwordValidator = new PasswordValidator();
        
        Assert.True(passwordValidator.Validate(ValidPassword));
    }
    
    [Fact]
    public void RejectPasswordWithoutNumbers()
    {
        var passwordValidator = new PasswordValidator();
        
        Assert.False(passwordValidator.Validate(NumberlessPassword));
    }
    
    [Fact]
    public void AcceptPasswordWithUnderscores()
    {
        var passwordValidator = new PasswordValidator();
        
        Assert.True(passwordValidator.Validate(ValidPassword));
    }
    
    [Fact]
    public void RejectPasswordWithoutUnderscores()
    {
        var passwordValidator = new PasswordValidator();
        
        Assert.False(passwordValidator.Validate(UnderscorelessPassword));
    }
}