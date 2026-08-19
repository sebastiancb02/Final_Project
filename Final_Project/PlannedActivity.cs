namespace Final_Project;

public class PlannedActivity
{
    public string title { get; set; }
    public ActivityType type { get; set; }
    public DateTime date { get; set; }
    public string location { get; set; }
    public List<User> participants { get; set; }
}