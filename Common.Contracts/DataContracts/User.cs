using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Web.Mvc;


namespace Common.DataContracts
{
    [DataContract]
    class User
    {
        [DataMember]
        public int UserID { get; set; }

        [DataMember]
        public int GroupID { get; set; }

        [DataMember]
        public string Username { get; set; }

        [DataMember]
        public string Password { get; set; }
    }
}
