using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusHotel.Classes
{
    internal enum RoomStatus
    {
        AVAILABLE,
        OCCUPIED,
        CLEANING
    }
    internal class Room
    {
        public int Number { get; private set; }
        public RoomStatus Status { get; private set; }
        public int Beds { get; private set; }
        public double Price { get; private set; }

    }
}
