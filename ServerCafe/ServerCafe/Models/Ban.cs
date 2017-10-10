using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
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
        public string TenBan { get; set; }
        [DataMember]
        public string IDKhuVuc { get; set; }
        [ForeignKey("IDKhuVuc")]
        [DataMember]
        public virtual KhuVuc KhuVuc { get; set; }
        [DataMember]
        public int TrangThai { get; set; }
        [DataMember]
        public int TongTien { get; set; }
    }
}