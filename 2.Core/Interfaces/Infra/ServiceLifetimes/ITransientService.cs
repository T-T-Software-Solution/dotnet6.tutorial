namespace _2.Core;

public interface ITransientService
{
    public int GetRequestedCount();
    public int GetScopedRequestedCount();
    public int GetSingletonRequestedCount();
}