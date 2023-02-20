namespace _1.Core;

public interface ITokenService
{
    Task<string> SendEmailTokenAsync();
}