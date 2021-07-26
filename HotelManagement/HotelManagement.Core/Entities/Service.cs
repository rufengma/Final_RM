using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HotelManagement.Core.Entities
{
    public class Service
    {
        public int Id { get; set; }
        public int RoomNo { get; set; }
        public string SDesc { get; set; }
        public decimal Amount { get; set; }
        public DateTime ServiceDate { get; set; }

        public Room Rooms { get; set; }

    }
}
