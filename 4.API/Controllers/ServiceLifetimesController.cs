using Microsoft.AspNetCore.Mvc;
using _2.Core;

namespace _4.API.Controllers;

[ApiController]
[Route("[controller]")]
public class ServiceLifetimesController : ControllerBase
{
    private readonly ITransientService _transientService;
    private readonly ITransientService _transientServiceTwo;
    private readonly ITransientService _transientServiceThree;
    private readonly IScopedService _scopeService;
    private readonly ISingletonService _singletonService;
    public ServiceLifetimesController(
        ITransientService transientService,
        ITransientService transientServiceTwo,
        ITransientService transientServiceThree, 
        IScopedService scopeService, 
        ISingletonService singletonService)
    {
        this._transientService = transientService;
        this._transientServiceTwo = transientServiceTwo;
        this._transientServiceThree = transientServiceThree;

        this._scopeService = scopeService;
        this._singletonService = singletonService;

    }

    public class GetServiceLifeTimesPOCResult
    {
        public GetServiceLifeTimesPOCResultGetInstantConstructionTime Transient { get; set; }
        public GetServiceLifeTimesPOCResultGetInstantConstructionTime TransientTwo { get; set; }
        public GetServiceLifeTimesPOCResultGetInstantConstructionTime TransientThree { get; set; }
        public int Scoped { get; set; }
        public int Singleton { get; set; }
    }

    public class GetServiceLifeTimesPOCResultGetInstantConstructionTime
    {
        public int Transient { get; set; }
        public int Scoped { get; set; }
        public int Singleton { get; set; }
    }

    [HttpGet(Name = "GetServiceLifeTimesPOC")]
    public GetServiceLifeTimesPOCResult GetServiceLifeTimesPOC()
    {
        return new GetServiceLifeTimesPOCResult()
        {
            Transient = new GetServiceLifeTimesPOCResultGetInstantConstructionTime()
            {
                Transient = _transientService.GetRequestedCount(),
                Scoped = _transientService.GetScopedRequestedCount(),
                Singleton = _transientService.GetSingletonRequestedCount()
            },

            TransientTwo = new GetServiceLifeTimesPOCResultGetInstantConstructionTime()
            {
                Transient = _transientServiceTwo.GetRequestedCount(),
                Scoped = _transientServiceTwo.GetScopedRequestedCount(),
                Singleton = _transientServiceTwo.GetSingletonRequestedCount()
            },

            TransientThree = new GetServiceLifeTimesPOCResultGetInstantConstructionTime()
            {
                Transient = _transientServiceThree.GetRequestedCount(),
                Scoped = _transientServiceThree.GetScopedRequestedCount(),
                Singleton = _transientServiceThree.GetSingletonRequestedCount()
            },

            Scoped = _scopeService.GetRequestedCount(),
            Singleton = _singletonService.GetRequestedCount()
        };
    }
}