using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Cosmos;
using TestDatabaseProject.Entities;
using TestDatabaseProject.Interfaces;

namespace TestDatabaseProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuestController : ControllerBase
    {
        public ICosmosDbClient _dbClient { get; set; }

        public GuestController(ICosmosDbClient cosmosDb)
        {
            _dbClient = cosmosDb;
        }

        [HttpPost("guest")]
        public async Task<IActionResult> CreateGuest([FromBody]Guest guest)
        {
            try
            {
                var item = await _dbClient.GuestContainer.CreateItemAsync<Guest>(guest);
                return Ok(item.Resource);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return BadRequest();
        }

        [HttpGet("guest/{id}")]
        public async Task<IActionResult> GetGuest(string id)
        {
            try
            {
                var item = await _dbClient.GuestContainer.ReadItemAsync<Guest>(id, new PartitionKey(id));
                return Ok(item.Resource);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return BadRequest();
        }

        [HttpDelete("guest/{id}")]
        public async Task<IActionResult> DeleteGuest(string id)
        {
            try
            {
                var item = await _dbClient.GuestContainer.DeleteItemAsync<Guest>(id, new PartitionKey(id));
                return Ok(item.Resource);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return BadRequest();
        }
    }
}
