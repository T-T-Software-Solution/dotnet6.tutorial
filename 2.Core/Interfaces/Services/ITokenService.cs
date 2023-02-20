namespace _2.Core;

public interface ITokenService
{
    Task<string> SendEmailTokenAsync();
}