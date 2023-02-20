namespace _2.Core;

public class TokenService : ITokenService
{
    private readonly IEmailProvider _emailProvider;
    public TokenService(IEmailProvider emailProvider)
    {
        _emailProvider = emailProvider;
    }

    public async Task<string> SendEmailTokenAsync()
    {
        return await _emailProvider.SendEmailAsync(
                subject: "Sending a new token to you", 
                message: "Please save the token 'XXXXX'",
                recepients: new List<string>(){"dummy@mail.com"}
                );
    }
}