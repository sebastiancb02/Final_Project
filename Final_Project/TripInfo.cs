namespace Final_Project;

public class TripInfo
{
    public string country { get; set; }
    public string city { get; set; }
    public DateOnly startDate { get; set; }
    public DateOnly endDate { get; set; }
    public bool tripAlreadyBooked { get; set; }
}