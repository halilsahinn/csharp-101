using System;

namespace _2_Fly_Management_System
{
    public class Flight:Plane
    {

        public Flight()
        {
            FlightId = Guid.NewGuid();
        }

        public Guid FlightId { get; set; }


        public string ToFrom { get; set; }
        public string ToWhere { get; set; }

        public string Pilot { get; set; }

        public string CoPilot { get; set; }

        public DateTime DepartureTime { get; set; }

        public DateTime LandingTime { get; set; }

    }
}