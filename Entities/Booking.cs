using Newtonsoft.Json;

namespace TestDatabaseProject.Entities
{
    public class Booking
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }
        [JsonProperty("roomTypeId")]
        public int RoomTypeId { get; set; }
        [JsonProperty("guestId")]
        public int GuestId { get; set; }
        [JsonProperty("checkIn")]
        public DateTimeOffset CheckIn { get; set; }
        [JsonProperty("checkOut")]
        public DateTimeOffset CheckOut { get; set; }
    }
}
