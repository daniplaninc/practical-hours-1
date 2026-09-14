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
}