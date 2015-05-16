using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Web.Mvc;

namespace Common.DataContracts
{
    [DataContract]
    public class Group
    {
        [DataMember]
        public int PageID { get; set; }

        [DataMember]
        public string Elements { get; set; }
    }
}
