namespace Final_Project;

public class PlannedActivity
{
    public int activityId { get; set; }
    public User creatorOfTheActivity { get; set; }
    public string title { get; set; }
    public ActivityType type { get; set; }
    public DateOnly date { get; set; }
    public string location { get; set; }
    public List<User> participants { get; set; }
    public bool activityIsExpired { get; set; }
}