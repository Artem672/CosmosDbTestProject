using Newtonsoft.Json;

namespace TestDatabaseProject.Entities
{
    public class Room
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }
        [JsonProperty("number")]
        public int Number { get; set; }
        [JsonProperty("roomTypeId")]
        public int RoomTypeId { get; set; }
        [JsonProperty("roomPrice")]
        public int RoomPrice { get; set; }
        [JsonProperty("roomStatus")]
        public bool RoomStatus { get; set; }
    }
}
