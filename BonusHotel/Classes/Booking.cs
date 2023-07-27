using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusHotel.Classes
{
    internal enum BookingStatus
    {
        PLANNED,
        IN_PROGRESS,
        FINISHED,
        CANCELED,
    }
    internal class Booking
    {
        public string ID { get; private set; }
        public BookingStatus Status { get; private set; }
        public List<Room> Rooms { get; private set; }
        public Client Client { get; private set; }

    }
}
