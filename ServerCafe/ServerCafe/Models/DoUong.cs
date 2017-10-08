using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ServerCafe.Models
{
    [Table("DoUong")]
    [DataContract(IsReference = true)]
    public class DoUong
    {
        [Key]
        [DataMember]
        public string IDDoUong { get; set; }
        [DataMember]
        public string TenDoUong { get; set; }
        [DataMember]
        public string IDLoaiDoUong { get; set; }
        [ForeignKey("IDLoaiDoUong")]
        [DataMember]
        public virtual LoaiDoUong LoaiDoUong { get; set; }
        [DataMember]
        public int GiaTien { get; set; }
        [DataMember]
        public int KhuyenMai { get; set; }
        [DataMember]
        public string IDNoiIn { get; set; }
        [ForeignKey("IDNoiIn")]
        
        [DataMember]
        public virtual NoiIn NoiIn { get; set; }
        [DataMember]
        public virtual ICollection<ThanhPhanDoUong> ThanhPhanDoUongs { get; set; }
    }
}