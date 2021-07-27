using System;
namespace HotelManagement.Core.Models
{
    public class AddServiceModel
    {
        public int Id { get; set; }
        public int RoomNo { get; set; }
        public string SDesc { get; set; }
        public decimal Amount { get; set; }
        public DateTime ServiceDate { get; set; }
    }
}
