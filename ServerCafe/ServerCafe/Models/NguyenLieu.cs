using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ServerCafe.Models
{
    [Table("NguyenLieu")]
    [DataContract(IsReference =true)]
    public class NguyenLieu
    {
        [Key]
        [DataMember]
        public string IDNguyenLieu { get; set; }
        [DataMember]
        public string TenNguyenLieu { get; set; }
        [DataMember]
        public string DonViTinh { get; set; }
        [DataMember]
        public float Gia { get; set; }
        [DataMember]
        public float SoLuong { get; set; }
        [IgnoreDataMember]
        public virtual ICollection<ThanhPhanDoUong> ThanhPhanDoUongs { get; set; }
        
    }
}