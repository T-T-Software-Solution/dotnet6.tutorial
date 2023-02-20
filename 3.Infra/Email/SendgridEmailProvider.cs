using _1.Core;
using Microsoft.Extensions.Options;

namespace _3.Infra;

public class SendgridEmailProvider : IEmailProvider
{
    protected readonly SendgridEmailProviderOptions _options;
    public SendgridEmailProvider(IOptions<SendgridEmailProviderOptions> options)
    {
        _options = options.Value;
    }

    public async Task<string> SendEmailAsync(string subject, string message, List<string> recepients)
    {
        string sendingResult = "";

        await Task.Run(() => 
        {
            sendingResult = $"Email Provider: !! SENDGRID - SMTP !! {Environment.NewLine}" +
            $"Host: {_options.Host} {Environment.NewLine}" +
            $"UserName: {_options.UserName} {Environment.NewLine}" +
            $"Password: {_options.Password} {Environment.NewLine}" +
            $"Subject: {subject} {Environment.NewLine}" +
            $"Message: {message} {Environment.NewLine}" +
            $"Recepients Provider: {String.Join(", ", recepients)}";
        });     

        return sendingResult;
    }
}