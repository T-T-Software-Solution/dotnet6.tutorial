using _2.Core;

namespace _3.Infra;

public class TransientService : ITransientService
{
    private int _requestedCount;
    private readonly IScopedService _scopeService;
    private readonly ISingletonService _singletonService;
    public TransientService(IScopedService scopeService, ISingletonService singletonService)
    {
        this._scopeService = scopeService;
        this._singletonService = singletonService;
    }

    public int GetRequestedCount()
    {
        _requestedCount = _requestedCount + 1;
        return _requestedCount;
    }

    public int GetScopedRequestedCount() => this._scopeService.GetRequestedCount();

    public int GetSingletonRequestedCount() => this._singletonService.GetRequestedCount();
}