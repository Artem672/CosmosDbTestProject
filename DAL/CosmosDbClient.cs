using Microsoft.Azure.Cosmos;
using TestDatabaseProject.Entities;
using TestDatabaseProject.Interfaces;

namespace TestDatabaseProject.DAL
{
    internal class CosmosDbClient : ICosmosDbClient
    {
        private readonly string _URI;
        private readonly string _PrimaryKey;
        private CosmosClient _cosmosClient;
        private Database _database;
        private string _databaseName = "ReservationSystem";
        private string _guestContainerName = "guest";
        private string _partitionKey = "/id";
        private string _bookingContainerName = "booking";
        private string _paymentContainerName = "payment";
        private string _reservationContainerName = "reservation";
        private string _roomContainerName = "room";
        private string _roomTypeContainerName = "roomType";

        public Container GuestContainer { get; private set; }
        public Container BookingContainer { get; private set; }
        public Container PaymentContainer { get; private set; }
        public Container ReservationContainer { get; private set; }
        public Container RoomContainer { get; private set; }
        public Container RoomTypeContainer { get; private set; }
        public CosmosDbClient(IConfiguration configuration)
        {
            this._URI = configuration["EndpointUri"];
            this._PrimaryKey = configuration["PrimaryKey"];
        }

        public async void Init()
        {
            _cosmosClient = new CosmosClient(this._URI, this._PrimaryKey);
            _database = await _cosmosClient.CreateDatabaseIfNotExistsAsync(_databaseName);
            GuestContainer = await _database.CreateContainerIfNotExistsAsync(_guestContainerName, _partitionKey);
            BookingContainer = await _database.CreateContainerIfNotExistsAsync(_bookingContainerName, _partitionKey);
            PaymentContainer = await _database.CreateContainerIfNotExistsAsync(_paymentContainerName, _partitionKey);
            ReservationContainer = await  _database.CreateContainerIfNotExistsAsync(_reservationContainerName, _partitionKey);
            RoomContainer = await _database.CreateContainerIfNotExistsAsync(_roomContainerName, _partitionKey);
            RoomTypeContainer = await _database.CreateContainerIfNotExistsAsync(_roomTypeContainerName, _partitionKey);
        }
    }
}
