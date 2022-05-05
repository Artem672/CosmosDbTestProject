using Newtonsoft.Json;

namespace TestDatabaseProject.Entities
{
    public class Guest
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }
        [JsonProperty("firstName")]
        public string FirstName { get; set; }
        [JsonProperty("lastName")]
        public string LastName { get; set; }
        [JsonProperty("address")]
        public string Address { get; set; }
        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
    }
}
