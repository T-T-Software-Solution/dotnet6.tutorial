using _2.Core;
using Microsoft.Extensions.Options;

namespace _3.Infra;

public class MailGunEmailProvider : IEmailProvider
{
    protected readonly MailGunEmailProviderOptions _options;
    public MailGunEmailProvider(IOptions<MailGunEmailProviderOptions> options)
    {
        _options = options.Value;
    }

    public async Task<string> SendEmailAsync(string subject, string message, List<string> recepients)
    {
        string sendingResult = "";

        await Task.Run(() => 
        {
            sendingResult = $"Email Provider: !! MAILGUN - RESTFul API !! {Environment.NewLine}" +
            $"APIURL: {_options.APIURL} {Environment.NewLine}" +
            $"APIKey: {_options.APIKey} {Environment.NewLine}" +
            $"Subject: {subject} {Environment.NewLine}" +
            $"Message: {message} {Environment.NewLine}" +
            $"Recepients Provider: {String.Join(", ", recepients)}";
        });     
        
        return sendingResult;
    }
}