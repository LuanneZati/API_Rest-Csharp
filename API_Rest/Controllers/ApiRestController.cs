using API_Rest.Models;
using API_Rest.Services.ApiRest;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace API_Rest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiRestController : ControllerBase
    {
        private readonly IApiRest _apiRestService;
        public ApiRestController(IApiRest apiRestService)
        {
            _apiRestService = apiRestService;
        }
        [HttpGet]
        public async Task<ActionResult<List<ApiRestClass>>> GetAllResults()
        {
            return await _apiRestService.GetAllResults();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ApiRestClass>> GetSingleResult(int id)
        {
            var result = await _apiRestService.GetSingleResult(id);
            if (result == null)
                return NotFound("Not found!");
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<ApiRestClass>>> AddData(ApiRestClass data)
        {
            var result = await _apiRestService.AddData(data);
            if (result == null)
                return NotFound("Not found!");
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<ApiRestClass>>> UpdateResult(int id, ApiRestClass request)
        {
            var result = await _apiRestService.UpdateResult(id, request);
            if (result == null)
                return NotFound("Not found!");
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<ApiRestClass>>> DeleteResult(int id)
        {
            var result = await _apiRestService.DeleteResult(id);
            if (result == null)
                return NotFound("Not found!");
            return Ok(result);
        }
    }
}
