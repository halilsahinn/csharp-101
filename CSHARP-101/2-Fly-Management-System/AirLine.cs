using System;

namespace _2_Fly_Management_System
{
    public class AirLine
    {

        public AirLine()
        {
            AirLineId = Guid.NewGuid();
        }

        public Guid AirLineId { get; set; }


        public PlaneType PlaneType { get; set; }
        public PlaneStatus PlaneStatus { get; set; }

        public Pilot Pilot { get; set; }


    }
}