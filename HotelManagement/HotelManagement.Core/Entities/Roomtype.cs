using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HotelManagement.Core.Entities
{
    public class Roomtype
    {
        public int Id { get; set; }
        public string RTDesc { get; set; }
        public decimal Rent { get; set; }

        public ICollection<Room> Rooms { get; set; }
    }
}
