using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ServerCafe.Models
{
    [Table("ChiTietOrder")]
    [DataContract(IsReference = true)]
    public class ChiTietOrder
    {
        [Key]
        [DataMember]
        public string IDChiTietOrder { get; set; }
        [DataMember]
        public string IDOrder { get; set; }
        [ForeignKey("IDOrder")]
        [DataMember]
        public virtual Order Order { get; set; }
        [DataMember]
        public string IDDoUong { get; set; }
        [ForeignKey("IDDoUong")]
        [DataMember]
        public virtual DoUong DoUong { get; set; }
        [DataMember]
        public int SoLuong { get; set; }
        [DataMember]
        public string GhiChu { get; set; }
        [DataMember]
        public string ThoiGian { get; set; }
        [DataMember]
        public bool DaIn { get; set; }
       
    }
}