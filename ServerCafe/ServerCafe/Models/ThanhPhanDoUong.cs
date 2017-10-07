using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ServerCafe.Models
{
    [Table("ThanhPhanDoUong")]
    [DataContract(IsReference =true)]
    public class ThanhPhanDoUong
    {
        [Key]
        [DataMember]
        public string IDThanhPhanDoUong { get; set; }
        [DataMember]
        public string IDDoUong { get; set; }
        [ForeignKey("IDDoUong")]
        [IgnoreDataMember]
        public virtual DoUong DoUong { get; set; }
        [DataMember]
        public string IDNguyenLieu { get; set; }
        [ForeignKey("IDNguyenLieu")]
        [IgnoreDataMember]
        public virtual NguyenLieu NguyenLieu { get; set; }
        [DataMember]
        public float SoLuong { get; set; }
    }
}