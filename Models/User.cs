using System;
using System.Collections.Generic;

namespace Practise.Models
{
    public class User
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }

        public IEnumerable<Record> Records { get; set; }
    }
}
