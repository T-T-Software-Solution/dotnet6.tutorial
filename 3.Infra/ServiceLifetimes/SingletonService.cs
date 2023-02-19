using _2.Core;

namespace _3.Infra;

public class SingletonService : ISingletonService
{
    private int _requestedCount;
    public SingletonService() {}

    public int GetRequestedCount()
    {
        _requestedCount = _requestedCount + 1;
        return _requestedCount;
    }
}