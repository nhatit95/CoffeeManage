using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServerCafe.Models
{
    [Table("Ban")]
    [DataContract(IsReference = true)]
    public class Ban
    {
        [Key]
        [DataMember]
        public string IDBan { get; set; }
        [DataMember]
        public string IDKhuVuc { get; set; }
        [DataMember]
        public virtual ICollection<Ban> Bans { get; set; }
    }
}