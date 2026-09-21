namespace Final_Project;

public class Logic
{
    public static Dictionary<string, List<User>> MatchUsersByLocation(List<User> listOfUsers)
    {
        var usersPerLocation = new Dictionary<string, List<User>>();
        //initializing dictionary with all the available locations
        foreach (var user in listOfUsers)
        {
            foreach (var trip in user.trips)
            {
                usersPerLocation.TryAdd(trip.city,new List<User>());
            }
        }

        //populating the user list per location
        foreach (var location in usersPerLocation.Keys) //first iteration is Stockholm
        {
            foreach (var user in listOfUsers)
            {
                foreach (var trip in user.trips)
                {
                    if (location == trip.city)
                    {
                        usersPerLocation[location].Add(user);
                    }
                }
            }
        }
        // usersPerLocation contains all the available locations, and for each location it contains the list of users going to this location
        
        return usersPerLocation;
    }
}