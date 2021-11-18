using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Models
{
    public class Hotel
    {
        public string? HotelName { get; set; }
        public string? Address {  get; set; }
        public string? Classification {  get; set; }
        public string? ReviewPoints { get; set; }
        public string? NumberOfReviews { get; set; }
        public string? Description { get; set; }
        public IList<string>? RoomCategories {  get; set; }
        public IList<string>? AlternativeHotels { get; set; }
    }
}
