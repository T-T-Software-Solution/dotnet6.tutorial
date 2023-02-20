namespace _3.Infra;

public class SendgridEmailProviderOptions
{
    public const string ConfigItem = "SendgridEmailProvider";

    public string Host { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
}