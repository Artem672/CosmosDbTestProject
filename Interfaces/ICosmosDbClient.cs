using Microsoft.Azure.Cosmos;

namespace TestDatabaseProject.Interfaces
{
    public interface ICosmosDbClient
    {
        public void Init();
        public Container GuestContainer { get; }
        public Container BookingContainer { get; }
        public Container PaymentContainer { get; }
        public Container ReservationContainer { get; }
        public Container RoomContainer { get; }
        public Container RoomTypeContainer { get; }
    }
}
