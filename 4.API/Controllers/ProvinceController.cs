using Microsoft.AspNetCore.Mvc;
using _2.Core;

namespace _4.API.Controllers;

[ApiController]
[Route("[controller]")]
public class ProvinceController : ControllerBase
{
    private readonly IProvinceService _provinceService;
    public ProvinceController(IProvinceService provinceService)
    {
        this._provinceService = provinceService;
    }

    [HttpPost]
    public async Task<ActionResult<ProvinceServiceResponse>> CreateNewProvinceAsync(ProvinceServiceInput input)
    {
        try
        {
            return Ok(await _provinceService.CreateNewProvinceAsync(input));
        }
        catch(Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<ProvinceServiceResponse>> UpdateProvinceAsync(Guid id, ProvinceServiceInput input)
    {
        try
        {
            return Ok(await _provinceService.UpdateProvinceAsync(id, input));
        }
        catch(ArgumentException ex)
        {
            return StatusCode(StatusCodes.Status404NotFound, ex.Message);
        }
        catch(Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<ProvinceServiceResponse>> DeleteProvinceAsync(Guid id)
    {
        try
        {
            return Ok(await _provinceService.DeleteProvinceAsync(id));
        }
        catch(ArgumentException ex)
        {
            return StatusCode(StatusCodes.Status404NotFound, ex.Message);
        }
        catch(Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ProvinceServiceResponse>> GetProvinceAsync(Guid id)
    {
        try
        {
            return Ok(await _provinceService.GetProvinceAsync(id));
        }
        catch(ArgumentException ex)
        {
            return StatusCode(StatusCodes.Status404NotFound, ex.Message);
        }
        catch(Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    [HttpGet("GetProvinceAsyncWithPointOfInterestAsync")]
    public async Task<ActionResult<ProvinceServiceResponseWithPointOfInterest>> GetProvinceAsyncWithPointOfInterestAsync(Guid id)
    {
        try
        {
            return Ok(await _provinceService.GetProvinceAsyncWithPointOfInterestAsync(id));
        }
        catch(ArgumentException ex)
        {
            return StatusCode(StatusCodes.Status404NotFound, ex.Message);
        }
        catch(Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }
}