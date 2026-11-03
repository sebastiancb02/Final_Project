namespace Final_Project;

public class UserImage
{
    public int userImageId { get; set; }
    public string profileImagePath { get; set; } = "";
    public List<string> galleryImagePath { get; set; } 
    public bool isPrimary { get; set; }
}