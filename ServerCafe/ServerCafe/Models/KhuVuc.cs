using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
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
        public string TenKhuVuc { get; set; }
        [DataMember]
        public virtual ICollection<Ban> Bans { get; set; }
    }
}