using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string RoomNo { get; set; }
        public int Floor { get; set; }
        public int RoomTypeId { get; set; }
        public decimal PricePerNight { get; set; }
        public string Description { get; set; }
        public string Status { get; set; } = "Available";
    }
}

