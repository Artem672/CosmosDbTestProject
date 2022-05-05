using Newtonsoft.Json;

namespace TestDatabaseProject.Entities
{
    public class RoomType
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
