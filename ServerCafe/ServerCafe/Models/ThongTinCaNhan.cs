using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ServerCafe.Models
{
    [Table("ThongTinCaNhan")]
    [DataContract(IsReference = true)]
    public class ThongTinCaNhan
    {
        [Key]
        [DataMember]
        public string IDUser { get; set; }
        [DataMember]
        public string Email { get; set; }
        
        [DataMember]
        public string IDChucVu { get; set; }
        [ForeignKey("IDChucVu")]
        [IgnoreDataMember]
        public virtual ChucVu ChucVu { get; set; }
        [DataMember]
        public string Ten { get; set; }
        [DataMember]
        public string DiaChi { get; set; }
        [DataMember]
        public string SDT { get; set; }
        [DataMember]
        public string NgaySinh { get; set; }
        [DataMember]
        public int NangLucLamViec { get; set; }
        


}
}