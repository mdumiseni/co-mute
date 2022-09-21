namespace CoMute.API.Model
{
    public class CarPool
    {
        public int CreatedByUserId { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ExpectedArrivalTime { get; set; }
        public string Origin { get; set; }
        public int DaysAvailable { get; set; }
        public string Destination { get; set; }
        public int AvailableSeats { get; set; }
        public string Notes { get; set; }
    }
}
