using System;

namespace _2_Fly_Management_System
{
    public class AirPort
    {
        public AirPort()
        {
            AirPortId = Guid.NewGuid();
        }

        public Guid AirPortId { get; set; }

    }
}