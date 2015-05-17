using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Web.Mvc;

namespace Common.DataContracts
{
    [DataContract]
    public class Page
    {
        [DataMember]
        public int PageID { get; set; }

        [DataMember]
        public int ProjectID { get; set; }

        [DataMember]
        public string Elements { get; set; }
    }
}
