using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IPMockup.Models
{
    public class Project
    {
        public List<Page> Pages { get; set; }

        public string Username { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime LastEdit { get; set; }

        public List<UserData> AllowedUsers { get; set; }
    }
}