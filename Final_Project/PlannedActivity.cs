namespace Final_Project;

public class PlannedActivity
{
    public int activityId { get; set; }
    public User creatorOfTheActivity { get; set; }
    public string title { get; set; }
    public string description { get; set; }
    public ActivityType type { get; set; }
    public DateOnly date { get; set; }
    public string location { get; set; }
    public List<User> participants { get; set; } = new List<User>();
    public bool activityIsExpired { get; set; }
}