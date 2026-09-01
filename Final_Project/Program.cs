namespace Final_Project;

class Program
{
    static void Main(string[] args)
    {
        List<User> listOfUsers = new List<User>();
        List<TripInfo> listOfTrips = new List<TripInfo>();
        
        //Users-------------------------------------------------------------------------------------------
        User user1 = new User();
        user1.name = "John";
        user1.age = 21;
        user1.gender = "male";
        user1.nationality = "Austrian";
        listOfUsers.Add(user1);
        
        User user2 = new User();
        user2.name = "Jane";
        user2.age = 20;
        user2.gender = "female";
        user2.nationality = "English";
        listOfUsers.Add(user2);
        
        User user3 = new User();
        user3.name = "Felicia";
        user3.age = 22;
        user3.gender = "female";
        user3.nationality = "Norwegian";
        listOfUsers.Add(user3);
        
        User user4 = new User();
        user4.name = "Michael";
        user4.age = 21;
        user4.gender = "male";
        user4.nationality = "Austrian";
        listOfUsers.Add(user4);
        
        //Trips------------------------------------------------------------------------------------------
        TripInfo trip1 = new TripInfo();
        trip1.country = "Netherlands";
        trip1.city = "Amsterdam";
        trip1.startDate = new DateOnly(2027, 1, 1);
        trip1.endDate = new DateOnly(2027, 1, 16);
        trip1.tripAlreadyBooked = true;
        user1.trips.Add(trip1); 
        
        TripInfo trip2 = new TripInfo();
        trip2.country = "Netherlands";
        trip2.city = "Amsterdam";
        trip2.startDate = new DateOnly(2027, 1, 3);
        trip2.endDate = new DateOnly(2027, 1, 11);
        trip2.tripAlreadyBooked = true;
        user2.trips.Add(trip2); 
        
        TripInfo trip3 = new TripInfo();
        trip3.country = "Netherlands";
        trip3.city = "Amsterdam";
        trip3.startDate = new DateOnly(2027, 1, 7);
        trip3.endDate = new DateOnly(2027, 1, 12);
        trip3.tripAlreadyBooked = false;
        user3.trips.Add(trip3); 
        
        TripInfo trip4 = new TripInfo();
        trip4.country = "Greece";
        trip4.city = "Athens";
        trip4.startDate = new DateOnly(2027, 1, 19);
        trip4.endDate = new DateOnly(2027, 1, 29);
        trip4.tripAlreadyBooked = true;
        user4.trips.Add(trip4);
        
        

    }
}