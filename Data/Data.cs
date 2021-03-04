using System.Collections.Generic;
using System;

namespace netcoreReactTrips.Data {
    public static class Data {
        public static List<Trip> Trips => allTrips;

        static List<Trip> allTrips = new List<Trip>(){
            new Trip(){
                Id=1,
                Name="Vienna, Austria",
                Description="Vienna, is one the most beatiful cities in Austria",
                DateStarted = new DateTime(2017, 01, 20),
                DateCompleted = null
            },
            new Trip(){
                Id=2,
                Name="Carpenteria, CA, USA",
                Description="Carpenteria is a city located on the central",
                DateStarted = new DateTime(2019, 02, 22),
                DateCompleted = new DateTime(2019, 01, 30)
            },
              new Trip()
        {
            Id=3,
            Name="San Francisco, CA, USA",
            Description="San Francisco is a metropolitan area located on the west coast of the United States. Some popular tourist features include the Golden Gate Bridge, Chinatown, and Fisherman's Wharf. There are a variety of popular food options...",
            DateStarted = new DateTime(2019,01,27),
            DateCompleted = new DateTime(2019,01,30)
        },
        new Trip()
        {
            Id=4,
            Name="Tucson, AZ, USA",
            Description="Tucson is a southwestern city in Arizona that is home to the University of Arizona. It was recently named a world gastronomy city, and is well known for its desert landscape and various bike races...",
            DateStarted = new DateTime(2019,01,20),
            DateCompleted = null
        },
        new Trip()
        {
            Id=5,
            Name="Albuquerque, NM, USA",
            Description="Albuquerque is a city located in New Mexico that is famous for its balloon festivals, picturesque views and references to TV shows.",
            DateStarted = new DateTime(2015,01,20),
            DateCompleted = new DateTime(2015,01,30)
        },
        new Trip()
        {
            Id=7,
            Name="Munich, Germany",
            Description="Munich is an important city in Germany, located in the heart of Bavaria. It's famous for its traditional Oktoberfest annual festival, and many nice lakes and parks...",
            DateStarted = new DateTime(2019,01,20),
            DateCompleted = null
        }
        };
    }
}