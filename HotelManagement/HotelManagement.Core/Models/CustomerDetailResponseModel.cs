using System;
using System.Collections.Generic;
namespace HotelManagement.Core.Models
{
    public class CustomerDetailResponseModel
    {
        public int Id { get; set; }
        public int RoomNo { get; set; }// foreing key
        public string CName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime Checkin { get; set; }
        public int TotalPersons { get; set; }
        public int BookingDays { get; set; }
        public decimal? Advance { get; set; }

        public RoomModel roomModel { get; set; }
    }
    public class RoomModel
    {
        public int Id { get; set; }
        public int RTCode { get; set; }
        public byte status { get; set; }
        public List<ServiceModel> serviceModels { get; set; }
}

    public class ServiceModel
    {
        public int Id { get; set; }
        public int RoomNo { get; set; }
        public string SDesc { get; set; }
    }
}

