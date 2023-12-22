
namespace CourseWork.Models
{
    internal class Registration
    {
        public int Id { get; set; }
        public int IdBooking { get; set; }
        public int IdClient { get; set; }
        // Don't understand what that field about
        public string Client { get; set; } = default!;
        public int CountOfPeople { get; set; }
        public int RoomNumber { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime DepartureDate { get; set; }
        public int SumOfLiving { get; set; }
        public int SumOfServices { get; set; }
        public int TotalSum { get; set; }
    }
}
