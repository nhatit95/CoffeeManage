using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ServerCafe.Models
{
    [Table("ChucVu")]
    [DataContract(IsReference = true)]
    public class ChucVu
    {
        [Key]
        [DataMember]
        public string IDChucVu { get; set; }
        [DataMember]
        public string TenChucVu { get; set; }
        [DataMember]
        public int LuongCa { get; set; }
        [IgnoreDataMember]
        public virtual ICollection<ThongTinCaNhan> ThongTinCaNhans { get; set; }
    }
}