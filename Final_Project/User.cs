using System.IO.Pipes;

namespace Final_Project;

public class User
{
    public int userId { get; set; }
    public string name { get; set; }
    public int age { get; set; }
    public DateOnly dateOfBirth { get; set; }
    public string gender { get; set; }
    public string nationality { get; set; }
    public List<Languages> languagesSpokenByUser { get; set; } //= new List<Languages>;
    public List<TripInfo> trips { get; set; } = new List<TripInfo>();
    public List<PlannedActivity> listOfActivitiesPlannedByUser { get; set; } = new List<PlannedActivity>();
    public List<PlannedActivity> listOfActivitiesParticipatedByUser { get; set; }
    public UserImage image { get; set; } 

}    