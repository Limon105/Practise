using System;

namespace Practise.Models
{
    public class Record
    {
        public Guid Id { get; set; }

        public User Author { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime DateAdded { get; set; }

        public DateTime DateOfLastUpdate { get; set; }

        public Status Status { get; set; }
    }
}
