using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ServerCafe.Models
{
    [Table("LoaiDoUong")]
    [DataContract(IsReference =true)]
    public class LoaiDoUong
    {
        [Key]
        [DataMember]
        public string IDLoaiDoUong { get; set; }
        [DataMember]
        public string TenLoaiDoUong { get; set; }
        [IgnoreDataMember]
        public virtual ICollection<DoUong> DoUongs { get; set; }
    }
}