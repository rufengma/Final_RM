using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HotelManagement.Core.Entities
{
    public class Room
    {
        public int Id { get; set; }
        public int RTCode { get; set; }
        public byte status { get; set; }


        public Roomtype Roomtype { get; set; }
        public ICollection<Customer> Customers { get; set; }
        public ICollection<Service> Services { get; set; }


    }
}
