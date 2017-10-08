using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServerCafe.Models
{
    [Table("KhuVuc")]
    [DataContract(IsReference = true)]
    public class KhuVuc
    {
        [Key]
        [DataMember]
        public string IDKhuVuc { get; set; }
        [DataMember]
        public string KhuVuc { get; set; }
        [DataMember]
        public virtual ICollection<Ban> Bans { get; set; }
    }
}