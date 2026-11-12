namespace Final_Project;

public class Data
{
    public static List<User> GetUsers()
    {
        List<User> listOfUsers = new List<User>();
        
        User user1 = new User();
        user1.userId = 1;
        user1.name = "Sally";
        user1.dateOfBirth = new DateOnly(2001, 3, 7);
        user1.gender = "female";
        user1.nationality = "Swedish";
        listOfUsers.Add(user1);
        
        User user2 = new User();
        user2.userId = 2;
        user2.name = "Jane";
        user2.dateOfBirth = new DateOnly(2006, 4, 5);
        user2.gender = "female";
        user2.nationality = "English";
        listOfUsers.Add(user2);
        
        return listOfUsers;
    }

    public static List<User> GetUsersWithTrips()
    {
        List<User> listOfUsers = Data.GetUsers();
        
        TripInfo trip1 = new TripInfo();
        trip1.country = "Spain";
        trip1.city = "Barcelona";
        trip1.startDate = new DateOnly(2027, 1, 1);
        trip1.endDate = new DateOnly(2027, 1, 16);
        trip1.tripAlreadyBooked = true;
        listOfUsers[0].trips.Add(trip1);
        
        TripInfo trip2 = new TripInfo();
        trip2.country = "Spain";
        trip2.city = "Barcelona";
        trip2.startDate = new DateOnly(2027, 1, 3);
        trip2.endDate = new DateOnly(2027, 1, 11);
        trip2.tripAlreadyBooked = true;
        listOfUsers[1].trips.Add(trip2);

        return listOfUsers;
    }

    public static List<User> GetUsersWithTripsAndActivities()
    {
        List<User> listOfUsers = Data.GetUsersWithTrips();

        PlannedActivity activity1 = new PlannedActivity();
        activity1.creatorOfTheActivity = listOfUsers[0];
        activity1.title = "Go and watch seals";
        activity1.description = "I'd like to go to the beach and see if there are any seals in sight awawawawawawawa";
        activity1.type = ActivityType.Nature;
        activity1.date = new DateOnly(2027, 1, 5);
        activity1.location = "Barcelona";
        activity1.participants.Add(listOfUsers[1]);
        activity1.activityIsExpired = false;
        listOfUsers[0].trips[0].plannedActivities.Add(activity1);

        PlannedActivity activity2 = new PlannedActivity();
        activity2.creatorOfTheActivity = listOfUsers[1];
        activity2.title = "Getting a beer in town";
        activity2.description = "Let's go to a bar, grab a beer, and get to know each other";
        activity2.type = ActivityType.Social;
        activity2.date = new DateOnly(2027, 1, 8);
        activity2.location = "Barcelona";
        activity2.participants.Add(listOfUsers[0]);
        activity2.activityIsExpired = false;
        listOfUsers[1].trips[1].plannedActivities.Add(activity2);
        
        return listOfUsers;
    }
}