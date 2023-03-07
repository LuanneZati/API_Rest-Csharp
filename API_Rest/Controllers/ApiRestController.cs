using API_Rest.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Rest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiRestController : ControllerBase
    {
        private static List<ApiRest> results = new List<ApiRest>()
        {
            new ApiRest{Id= 1,
                Name="Spider Man",
                FirstName="Peter",
                LastName="Parker",
                PlaceName="New York City"
            },
            new ApiRest{Id= 2,
                Name="Iron Man",
                FirstName="Tony",
                LastName="Stark",
                PlaceName="Malibu City"
            }
        };
        [HttpGet]
        public async Task<ActionResult<List<ApiRest>>> GetAllResults()
        {
            return Ok(results);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ApiRest>> GetSingleResult(int id)
        {
            var single = results.Find(x => x.Id == id);
            if (single == null)
                return NotFound("Sorry, this doesn't exist!");
            return Ok(single);
        }

        [HttpPost]
        public async Task<ActionResult<List<ApiRest>>> AddData(ApiRest data)
        {
            results.Add(data);
            return Ok(results);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<ApiRest>>> UpdateResult(int id, ApiRest request)
        {
            var single = results.Find(x => x.Id == id);
            if (single == null)
                return NotFound("Sorry, this doesn't exist!");
            single.FirstName = request.FirstName;
            single.LastName = request.LastName;
            single.PlaceName = request.PlaceName;
            single.Name =  request.Name; 

            return Ok(results);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<ApiRest>>> DeleteResult(int id)
        {
            var single = results.Find(x => x.Id == id);
            if (single == null)
                return NotFound("Sorry, this doesn't exist!");
            results.Remove(single);

            return Ok(results);
        }
    }
}
