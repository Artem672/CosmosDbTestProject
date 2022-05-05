using Newtonsoft.Json;
using System.ComponentModel;

namespace TestDatabaseProject.Entities
{
    public class Payment
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("guestId")]
        public int GuestId { get; set; }
        [JsonProperty("guest")]
        public Guest Guest { get; set; }
        [JsonProperty("reservationId")]
        public int ReservationId { get; set; }
        [JsonProperty("roomPrice")]
        public int RoomPrice { get; set; }
        [JsonProperty("numberOfNights")]
        public int NumberOfNights { get; set; }
        [JsonProperty("total")]
        public int Total { get; set; }
        [DefaultValue(false)]
        [JsonProperty("paymentStatus")]
        public bool PaymentStatus { get; set; } = false;
    }
}
