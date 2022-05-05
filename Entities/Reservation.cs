using Newtonsoft.Json;
using System.ComponentModel;

namespace TestDatabaseProject.Entities
{
    public class Reservation
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }
        [JsonProperty("guestId")]
        public Guid GuestId { get; set; }
        [JsonProperty("roomTypeId")]
        public int RoomTypeId { get; set; }
        [JsonProperty("checkIn")]
        public DateTimeOffset CheckIn { get; set; }
        [JsonProperty("checkOut")]
        public DateTimeOffset CheckOut { get; set; }
        [DefaultValue(false)]
        [JsonProperty("reservationStatus")]
        public bool ReservationStatus { get; set; }
    }
}
