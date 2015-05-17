using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Web.Mvc;


namespace Common.DataContracts
{
    [DataContract]
    public class Project
    {
        public int ProjectID { get; set; }

        public int CreatorID { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime LastEdit { get; set;}

        public int GroupID { get; set; }
    }
}
