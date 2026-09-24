using System.IO.Pipes;

namespace Final_Project;

public class User
{
    public int userId { get; set; }
    public string name { get; set; }
    public int age { get; set; }
    public string gender { get; set; }
    public string nationality { get; set; }

    public List<TripInfo> trips { get; set; } = new List<TripInfo>();
}