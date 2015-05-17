using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Web.Mvc;

namespace Common.DataContracts
{
    [DataContract]
    public class Group
    {
        [DataMember]
        public int CreatorID { get; set; }

        [DataMember]
        public string ProjectID { get; set; }

        [DataMember]
        public int GroupID { get; set; }
    }
}
