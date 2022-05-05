using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Cosmos;
using TestDatabaseProject.Entities;
using TestDatabaseProject.Interfaces;

namespace TestDatabaseProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        public ICosmosDbClient _dbClient { get; set; }

        public RoomController(ICosmosDbClient cosmosDb)
        {
            _dbClient = cosmosDb;
        }

        [HttpPost("room")]
        public async Task<IActionResult> CreateRoom([FromBody]Room room)
        {
            try
            {
                var typeExist = await _dbClient.RoomTypeContainer.ReadItemAsync<RoomType>(room.RoomTypeId.ToString(), new PartitionKey(room.Id.ToString()));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Type does not exist!");
                return NotFound("Type does not exist!");
            }
            
            var item = await _dbClient.RoomContainer.CreateItemAsync(room);
            return Ok(item.Resource);
        }
    }
}
