namespace Final_Project;

public class Data
{
    public static List<User> GetUsers()
    {
        List<User> listOfUsers = new List<User>();
        
        //Users-------------------------------------------------------------------------------------------
        User user1 = new User();
        user1.userId = 1;
        user1.name = "John";
        user1.dateOfBirth = new DateOnly(2006, 1, 30);
        user1.gender = "male";
        user1.nationality = "Austrian";
        listOfUsers.Add(user1);
        
        User user2 = new User();
        user2.userId = 2;
        user2.name = "Jane";
        user2.age = 20;
        user2.dateOfBirth = new DateOnly(2006, 4, 5);
        user2.gender = "female";
        user2.nationality = "English";
        listOfUsers.Add(user2);
        
        User user3 = new User();
        user3.userId = 3;
        user3.name = "Felicia";
        user3.dateOfBirth = new DateOnly(2004, 7, 18);
        user3.gender = "female";
        user3.nationality = "Norwegian";
        listOfUsers.Add(user3);
        
        User user4 = new User();
        user4.userId = 4;
        user4.name = "Michael";
        user4.dateOfBirth = new DateOnly(2005, 4, 20);
        user4.gender = "male";
        user4.nationality = "Austrian";
        listOfUsers.Add(user4);
        
        User user5 = new User();
        user5.userId = 5;
        user5.name = "Lars";
        user5.dateOfBirth = new DateOnly(2003, 3, 12);
        user5.gender = "male";
        user5.nationality = "Swedish";
        listOfUsers.Add(user5);
         
        User user6 = new User();
        user6.userId = 6;
        user6.name = "Sophie";
        user6.dateOfBirth = new DateOnly(2005, 9, 22);
        user6.gender = "female";
        user6.nationality = "French";
        listOfUsers.Add(user6);
         
        User user7 = new User();
        user7.userId = 7;
        user7.name = "Marco";
        user7.dateOfBirth = new DateOnly(2002, 11, 3);
        user7.gender = "male";
        user7.nationality = "Italian";
        listOfUsers.Add(user7);
         
        User user8 = new User();
        user8.userId = 8;
        user8.name = "Ingrid";
        user8.dateOfBirth = new DateOnly(2004, 2, 14);
        user8.gender = "female";
        user8.nationality = "Norwegian";
        listOfUsers.Add(user8);
         
        User user9 = new User();
        user9.userId = 9;
        user9.name = "Diego";
        user9.dateOfBirth = new DateOnly(2001, 6, 30);
        user9.gender = "male";
        user9.nationality = "Spanish";
        listOfUsers.Add(user9);
         
        User user10 = new User();
        user10.userId = 10;
        user10.name = "Elena";
        user10.dateOfBirth = new DateOnly(2006, 8, 9);
        user10.gender = "female";
        user10.nationality = "Greek";
        listOfUsers.Add(user10);
         
        User user11 = new User();
        user11.userId = 11;
        user11.name = "Tomas";
        user11.dateOfBirth = new DateOnly(2003, 12, 25);
        user11.gender = "male";
        user11.nationality = "Czech";
        listOfUsers.Add(user11);
         
        User user12 = new User();
        user12.userId = 12;
        user12.name = "Beatriz";
        user12.dateOfBirth = new DateOnly(2005, 5, 17);
        user12.gender = "female";
        user12.nationality = "Portuguese";
        listOfUsers.Add(user12);
         
        User user13 = new User();
        user13.userId = 13;
        user13.name = "Henrik";
        user13.dateOfBirth = new DateOnly(2002, 1, 4);
        user13.gender = "male";
        user13.nationality = "Danish";
        listOfUsers.Add(user13);
         
        User user14 = new User();
        user14.userId = 14;
        user14.name = "Zsofia";
        user14.dateOfBirth = new DateOnly(2004, 10, 11);
        user14.gender = "female";
        user14.nationality = "Hungarian";
        listOfUsers.Add(user14);
         
        User user15 = new User();
        user15.userId = 15;
        user15.name = "Liam";
        user15.dateOfBirth = new DateOnly(2003, 7, 27);
        user15.gender = "male";
        user15.nationality = "Irish";
        listOfUsers.Add(user15);
         
        User user16 = new User();
        user16.userId = 16;
        user16.name = "Charlotte";
        user16.dateOfBirth = new DateOnly(2006, 3, 2);
        user16.gender = "female";
        user16.nationality = "English";
        listOfUsers.Add(user16);
         
        User user17 = new User();
        user17.userId = 17;
        user17.name = "Klaus";
        user17.dateOfBirth = new DateOnly(2001, 9, 19);
        user17.gender = "male";
        user17.nationality = "German";
        listOfUsers.Add(user17);
         
        User user18 = new User();
        user18.userId = 18;
        user18.name = "Isabella";
        user18.dateOfBirth = new DateOnly(2005, 4, 6);
        user18.gender = "female";
        user18.nationality = "Italian";
        listOfUsers.Add(user18);
         
        User user19 = new User();
        user19.userId = 19;
        user19.name = "Noah";
        user19.dateOfBirth = new DateOnly(2002, 2, 28);
        user19.gender = "male";
        user19.nationality = "Swiss";
        listOfUsers.Add(user19);
         
        User user20 = new User();
        user20.userId = 20;
        user20.name = "Amelie";
        user20.dateOfBirth = new DateOnly(2004, 6, 15);
        user20.gender = "female";
        user20.nationality = "Belgian";
        listOfUsers.Add(user20);
         
        User user21 = new User();
        user21.userId = 21;
        user21.name = "Erik";
        user21.dateOfBirth = new DateOnly(2003, 10, 8);
        user21.gender = "male";
        user21.nationality = "Swedish";
        listOfUsers.Add(user21);
         
        User user22 = new User();
        user22.userId = 22;
        user22.name = "Camille";
        user22.dateOfBirth = new DateOnly(2005, 1, 21);
        user22.gender = "female";
        user22.nationality = "French";
        listOfUsers.Add(user22);
         
        User user23 = new User();
        user23.userId = 23;
        user23.name = "Giovanni";
        user23.dateOfBirth = new DateOnly(2001, 12, 13);
        user23.gender = "male";
        user23.nationality = "Italian";
        listOfUsers.Add(user23);
         
        User user24 = new User();
        user24.userId = 24;
        user24.name = "Freya";
        user24.dateOfBirth = new DateOnly(2006, 5, 29);
        user24.gender = "female";
        user24.nationality = "Norwegian";
        listOfUsers.Add(user24);
         
        User user25 = new User();
        user25.userId = 25;
        user25.name = "Pablo";
        user25.dateOfBirth = new DateOnly(2002, 8, 17);
        user25.gender = "male";
        user25.nationality = "Spanish";
        listOfUsers.Add(user25);
         
        User user26 = new User();
        user26.userId = 26;
        user26.name = "Dimitra";
        user26.dateOfBirth = new DateOnly(2004, 11, 24);
        user26.gender = "female";
        user26.nationality = "Greek";
        listOfUsers.Add(user26);
         
        User user27 = new User();
        user27.userId = 27;
        user27.name = "Jakub";
        user27.dateOfBirth = new DateOnly(2003, 4, 9);
        user27.gender = "male";
        user27.nationality = "Czech";
        listOfUsers.Add(user27);
         
        User user28 = new User();
        user28.userId = 28;
        user28.name = "Mariana";
        user28.dateOfBirth = new DateOnly(2005, 9, 3);
        user28.gender = "female";
        user28.nationality = "Portuguese";
        listOfUsers.Add(user28);
         
        User user29 = new User();
        user29.userId = 29;
        user29.name = "Anders";
        user29.dateOfBirth = new DateOnly(2001, 7, 22);
        user29.gender = "male";
        user29.nationality = "Danish";
        listOfUsers.Add(user29);
         
        User user30 = new User();
        user30.userId = 30;
        user30.name = "Nora";
        user30.dateOfBirth = new DateOnly(2006, 2, 6);
        user30.gender = "female";
        user30.nationality = "Hungarian";
        listOfUsers.Add(user30);
         
        User user31 = new User();
        user31.userId = 31;
        user31.name = "Sean";
        user31.dateOfBirth = new DateOnly(2002, 10, 30);
        user31.gender = "male";
        user31.nationality = "Irish";
        listOfUsers.Add(user31);
         
        User user32 = new User();
        user32.userId = 32;
        user32.name = "Olivia";
        user32.dateOfBirth = new DateOnly(2004, 3, 18);
        user32.gender = "female";
        user32.nationality = "English";
        listOfUsers.Add(user32);
         
        User user33 = new User();
        user33.userId = 33;
        user33.name = "Stefan";
        user33.dateOfBirth = new DateOnly(2003, 6, 5);
        user33.gender = "male";
        user33.nationality = "German";
        listOfUsers.Add(user33);
         
        User user34 = new User();
        user34.userId = 34;
        user34.name = "Valentina";
        user34.dateOfBirth = new DateOnly(2005, 12, 1);
        user34.gender = "female";
        user34.nationality = "Italian";
        listOfUsers.Add(user34);
         
        User user35 = new User();
        user35.userId = 35;
        user35.name = "Lukas";
        user35.dateOfBirth = new DateOnly(2001, 5, 26);
        user35.gender = "male";
        user35.nationality = "Swiss";
        listOfUsers.Add(user35);
         
        User user36 = new User();
        user36.userId = 36;
        user36.name = "Chloe";
        user36.dateOfBirth = new DateOnly(2006, 9, 14);
        user36.gender = "female";
        user36.nationality = "Belgian";
        listOfUsers.Add(user36);
         
        User user37 = new User();
        user37.userId = 37;
        user37.name = "Viktor";
        user37.dateOfBirth = new DateOnly(2002, 1, 10);
        user37.gender = "male";
        user37.nationality = "Austrian";
        listOfUsers.Add(user37);
         
        User user38 = new User();
        user38.userId = 38;
        user38.name = "Maja";
        user38.dateOfBirth = new DateOnly(2004, 4, 23);
        user38.gender = "female";
        user38.nationality = "Swedish";
        listOfUsers.Add(user38);
         
        User user39 = new User();
        user39.userId = 39;
        user39.name = "Antoine";
        user39.dateOfBirth = new DateOnly(2003, 8, 8);
        user39.gender = "male";
        user39.nationality = "French";
        listOfUsers.Add(user39);
         
        User user40 = new User();
        user40.userId = 40;
        user40.name = "Greta";
        user40.dateOfBirth = new DateOnly(2005, 11, 19);
        user40.gender = "female";
        user40.nationality = "German";
        listOfUsers.Add(user40);
        
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
        
        TripInfo trip5 = new TripInfo();
        trip5.country = "France";
        trip5.city = "Paris";
        trip5.startDate = new DateOnly(2027, 2, 1);
        trip5.endDate = new DateOnly(2027, 2, 14);
        trip5.tripAlreadyBooked = true;
        user5.trips.Add(trip5);
         
        TripInfo trip6 = new TripInfo();
        trip6.country = "France";
        trip6.city = "Paris";
        trip6.startDate = new DateOnly(2027, 2, 5);
        trip6.endDate = new DateOnly(2027, 2, 20);
        trip6.tripAlreadyBooked = true;
        user6.trips.Add(trip6);
         
        TripInfo trip7 = new TripInfo();
        trip7.country = "France";
        trip7.city = "Paris";
        trip7.startDate = new DateOnly(2027, 2, 25);
        trip7.endDate = new DateOnly(2027, 3, 5);
        trip7.tripAlreadyBooked = false;
        user7.trips.Add(trip7);
        //Note: trip7 does NOT overlap trip5 or trip6 - same city, different (non-overlapping) dates
         
        //Same dates, different cities (should NOT match)
        TripInfo trip8 = new TripInfo();
        trip8.country = "Italy";
        trip8.city = "Rome";
        trip8.startDate = new DateOnly(2027, 2, 1);
        trip8.endDate = new DateOnly(2027, 2, 14);
        trip8.tripAlreadyBooked = true;
        user8.trips.Add(trip8);
         
        TripInfo trip9 = new TripInfo();
        trip9.country = "Spain";
        trip9.city = "Barcelona";
        trip9.startDate = new DateOnly(2027, 3, 10);
        trip9.endDate = new DateOnly(2027, 3, 24);
        trip9.tripAlreadyBooked = true;
        user9.trips.Add(trip9);
         
        TripInfo trip10 = new TripInfo();
        trip10.country = "Greece";
        trip10.city = "Athens";
        trip10.startDate = new DateOnly(2027, 1, 22);
        trip10.endDate = new DateOnly(2027, 1, 30);
        trip10.tripAlreadyBooked = true;
        user10.trips.Add(trip10);
        //trip10 overlaps trip4 (user4's Athens trip, Jan 19-29) - same city, overlapping dates
         
        TripInfo trip11 = new TripInfo();
        trip11.country = "Czech Republic";
        trip11.city = "Prague";
        trip11.startDate = new DateOnly(2027, 4, 1);
        trip11.endDate = new DateOnly(2027, 4, 10);
        trip11.tripAlreadyBooked = false;
        user11.trips.Add(trip11);
         
        TripInfo trip12 = new TripInfo();
        trip12.country = "Portugal";
        trip12.city = "Lisbon";
        trip12.startDate = new DateOnly(2027, 4, 5);
        trip12.endDate = new DateOnly(2027, 4, 15);
        trip12.tripAlreadyBooked = true;
        user12.trips.Add(trip12);
         
        TripInfo trip13 = new TripInfo();
        trip13.country = "Denmark";
        trip13.city = "Copenhagen";
        trip13.startDate = new DateOnly(2027, 5, 1);
        trip13.endDate = new DateOnly(2027, 5, 9);
        trip13.tripAlreadyBooked = true;
        user13.trips.Add(trip13);
         
        TripInfo trip14 = new TripInfo();
        trip14.country = "Hungary";
        trip14.city = "Budapest";
        trip14.startDate = new DateOnly(2027, 5, 3);
        trip14.endDate = new DateOnly(2027, 5, 12);
        trip14.tripAlreadyBooked = false;
        user14.trips.Add(trip14);
         
        TripInfo trip15 = new TripInfo();
        trip15.country = "Ireland";
        trip15.city = "Dublin";
        trip15.startDate = new DateOnly(2027, 6, 1);
        trip15.endDate = new DateOnly(2027, 6, 10);
        trip15.tripAlreadyBooked = true;
        user15.trips.Add(trip15);
         
        TripInfo trip16 = new TripInfo();
        trip16.country = "England";
        trip16.city = "London";
        trip16.startDate = new DateOnly(2027, 6, 5);
        trip16.endDate = new DateOnly(2027, 6, 18);
        trip16.tripAlreadyBooked = true;
        user16.trips.Add(trip16);
         
        TripInfo trip17 = new TripInfo();
        trip17.country = "Germany";
        trip17.city = "Berlin";
        trip17.startDate = new DateOnly(2027, 3, 1);
        trip17.endDate = new DateOnly(2027, 3, 11);
        trip17.tripAlreadyBooked = true;
        user17.trips.Add(trip17);
         
        TripInfo trip18 = new TripInfo();
        trip18.country = "Italy";
        trip18.city = "Milan";
        trip18.startDate = new DateOnly(2027, 3, 15);
        trip18.endDate = new DateOnly(2027, 3, 25);
        trip18.tripAlreadyBooked = false;
        user18.trips.Add(trip18);
         
        TripInfo trip19 = new TripInfo();
        trip19.country = "Switzerland";
        trip19.city = "Zurich";
        trip19.startDate = new DateOnly(2027, 7, 1);
        trip19.endDate = new DateOnly(2027, 7, 8);
        trip19.tripAlreadyBooked = true;
        user19.trips.Add(trip19);
         
        TripInfo trip20 = new TripInfo();
        trip20.country = "Belgium";
        trip20.city = "Brussels";
        trip20.startDate = new DateOnly(2027, 7, 3);
        trip20.endDate = new DateOnly(2027, 7, 12);
        trip20.tripAlreadyBooked = true;
        user20.trips.Add(trip20);
         
        //user21 has TWO trips - one overlaps user5/user6 in Paris, one is solo in Stockholm
        TripInfo trip21a = new TripInfo();
        trip21a.country = "France";
        trip21a.city = "Paris";
        trip21a.startDate = new DateOnly(2027, 2, 8);
        trip21a.endDate = new DateOnly(2027, 2, 16);
        trip21a.tripAlreadyBooked = true;
        user21.trips.Add(trip21a);
         
        TripInfo trip21b = new TripInfo();
        trip21b.country = "Sweden";
        trip21b.city = "Stockholm";
        trip21b.startDate = new DateOnly(2027, 8, 1);
        trip21b.endDate = new DateOnly(2027, 8, 9);
        trip21b.tripAlreadyBooked = false;
        user21.trips.Add(trip21b);
         
        TripInfo trip22 = new TripInfo();
        trip22.country = "Sweden";
        trip22.city = "Stockholm";
        trip22.startDate = new DateOnly(2027, 8, 4);
        trip22.endDate = new DateOnly(2027, 8, 14);
        trip22.tripAlreadyBooked = true;
        user22.trips.Add(trip22);
        //trip22 overlaps trip21b - same city, overlapping dates
         
        TripInfo trip23 = new TripInfo();
        trip23.country = "Norway";
        trip23.city = "Oslo";
        trip23.startDate = new DateOnly(2027, 9, 1);
        trip23.endDate = new DateOnly(2027, 9, 9);
        trip23.tripAlreadyBooked = true;
        user23.trips.Add(trip23);
         
        TripInfo trip24 = new TripInfo();
        trip24.country = "Norway";
        trip24.city = "Oslo";
        trip24.startDate = new DateOnly(2027, 9, 20);
        trip24.endDate = new DateOnly(2027, 9, 28);
        trip24.tripAlreadyBooked = false;
        user24.trips.Add(trip24);
        //trip24 does NOT overlap trip23 - same city, different (non-overlapping) dates
         
        TripInfo trip25 = new TripInfo();
        trip25.country = "Austria";
        trip25.city = "Vienna";
        trip25.startDate = new DateOnly(2027, 10, 1);
        trip25.endDate = new DateOnly(2027, 10, 10);
        trip25.tripAlreadyBooked = true;
        user25.trips.Add(trip25);
         
        TripInfo trip26 = new TripInfo();
        trip26.country = "Austria";
        trip26.city = "Vienna";
        trip26.startDate = new DateOnly(2027, 10, 6);
        trip26.endDate = new DateOnly(2027, 10, 16);
        trip26.tripAlreadyBooked = true;
        user26.trips.Add(trip26);
        //trip26 overlaps trip25 - same city, overlapping dates
         
        TripInfo trip27 = new TripInfo();
        trip27.country = "Spain";
        trip27.city = "Madrid";
        trip27.startDate = new DateOnly(2027, 11, 1);
        trip27.endDate = new DateOnly(2027, 11, 11);
        trip27.tripAlreadyBooked = false;
        user27.trips.Add(trip27);
         
        TripInfo trip28 = new TripInfo();
        trip28.country = "Spain";
        trip28.city = "Madrid";
        trip28.startDate = new DateOnly(2027, 11, 15);
        trip28.endDate = new DateOnly(2027, 11, 25);
        trip28.tripAlreadyBooked = true;
        user28.trips.Add(trip28);
        //trip28 does NOT overlap trip27 - same city, different (non-overlapping) dates
         
        //user29 has TWO trips
        TripInfo trip29a = new TripInfo();
        trip29a.country = "Netherlands";
        trip29a.city = "Amsterdam";
        trip29a.startDate = new DateOnly(2027, 1, 5);
        trip29a.endDate = new DateOnly(2027, 1, 14);
        trip29a.tripAlreadyBooked = true;
        user29.trips.Add(trip29a);
        //trip29a overlaps trip1, trip2, trip3 - same city (Amsterdam), overlapping dates
         
        TripInfo trip29b = new TripInfo();
        trip29b.country = "Portugal";
        trip29b.city = "Lisbon";
        trip29b.startDate = new DateOnly(2027, 4, 8);
        trip29b.endDate = new DateOnly(2027, 4, 18);
        trip29b.tripAlreadyBooked = false;
        user29.trips.Add(trip29b);
        //trip29b overlaps trip12 - same city (Lisbon), overlapping dates
         
        TripInfo trip30 = new TripInfo();
        trip30.country = "Hungary";
        trip30.city = "Budapest";
        trip30.startDate = new DateOnly(2027, 12, 1);
        trip30.endDate = new DateOnly(2027, 12, 10);
        trip30.tripAlreadyBooked = true;
        user30.trips.Add(trip30);
         
        TripInfo trip31 = new TripInfo();
        trip31.country = "Ireland";
        trip31.city = "Dublin";
        trip31.startDate = new DateOnly(2027, 6, 3);
        trip31.endDate = new DateOnly(2027, 6, 12);
        trip31.tripAlreadyBooked = true;
        user31.trips.Add(trip31);
        //trip31 overlaps trip15 - same city (Dublin), overlapping dates
         
        TripInfo trip32 = new TripInfo();
        trip32.country = "England";
        trip32.city = "London";
        trip32.startDate = new DateOnly(2027, 12, 15);
        trip32.endDate = new DateOnly(2027, 12, 24);
        trip32.tripAlreadyBooked = false;
        user32.trips.Add(trip32);
        //trip32 does NOT overlap trip16 - same city (London), different (non-overlapping) dates
         
        TripInfo trip33 = new TripInfo();
        trip33.country = "Germany";
        trip33.city = "Munich";
        trip33.startDate = new DateOnly(2027, 2, 1);
        trip33.endDate = new DateOnly(2027, 2, 9);
        trip33.tripAlreadyBooked = true;
        user33.trips.Add(trip33);
         
        TripInfo trip34 = new TripInfo();
        trip34.country = "Italy";
        trip34.city = "Milan";
        trip34.startDate = new DateOnly(2027, 3, 18);
        trip34.endDate = new DateOnly(2027, 3, 28);
        trip34.tripAlreadyBooked = true;
        user34.trips.Add(trip34);
        //trip34 overlaps trip18 - same city (Milan), overlapping dates
         
        TripInfo trip35 = new TripInfo();
        trip35.country = "Switzerland";
        trip35.city = "Zurich";
        trip35.startDate = new DateOnly(2027, 7, 5);
        trip35.endDate = new DateOnly(2027, 7, 15);
        trip35.tripAlreadyBooked = false;
        user35.trips.Add(trip35);
        //trip35 overlaps trip19 - same city (Zurich), overlapping dates
         
        //user36 has TWO trips, neither overlapping anyone
        TripInfo trip36a = new TripInfo();
        trip36a.country = "Belgium";
        trip36a.city = "Brussels";
        trip36a.startDate = new DateOnly(2027, 7, 20);
        trip36a.endDate = new DateOnly(2027, 7, 29);
        trip36a.tripAlreadyBooked = true;
        user36.trips.Add(trip36a);
         
        TripInfo trip36b = new TripInfo();
        trip36b.country = "Austria";
        trip36b.city = "Vienna";
        trip36b.startDate = new DateOnly(2027, 11, 1);
        trip36b.endDate = new DateOnly(2027, 11, 9);
        trip36b.tripAlreadyBooked = false;
        user36.trips.Add(trip36b);
         
        TripInfo trip37 = new TripInfo();
        trip37.country = "Greece";
        trip37.city = "Athens";
        trip37.startDate = new DateOnly(2027, 1, 24);
        trip37.endDate = new DateOnly(2027, 2, 2);
        trip37.tripAlreadyBooked = true;
        user37.trips.Add(trip37);
        //trip37 overlaps trip4 and trip10 - same city (Athens), overlapping dates with both
         
        TripInfo trip38 = new TripInfo();
        trip38.country = "Sweden";
        trip38.city = "Stockholm";
        trip38.startDate = new DateOnly(2027, 8, 10);
        trip38.endDate = new DateOnly(2027, 8, 20);
        trip38.tripAlreadyBooked = true;
        user38.trips.Add(trip38);
        //trip38 does NOT overlap trip21b or trip22 - same city (Stockholm), different (non-overlapping) dates
         
        TripInfo trip39 = new TripInfo();
        trip39.country = "France";
        trip39.city = "Paris";
        trip39.startDate = new DateOnly(2027, 2, 3);
        trip39.endDate = new DateOnly(2027, 2, 19);
        trip39.tripAlreadyBooked = false;
        user39.trips.Add(trip39);
        //trip39 overlaps trip5, trip6, and trip21a - same city (Paris), overlapping dates with all three
         
        TripInfo trip40 = new TripInfo();
        trip40.country = "Germany";
        trip40.city = "Berlin";
        trip40.startDate = new DateOnly(2027, 3, 4);
        trip40.endDate = new DateOnly(2027, 3, 14);
        trip40.tripAlreadyBooked = true;
        user40.trips.Add(trip40);
        //trip40 overlaps trip17 - same city (Berlin), overlapping dates

        return listOfUsers;
    }
}