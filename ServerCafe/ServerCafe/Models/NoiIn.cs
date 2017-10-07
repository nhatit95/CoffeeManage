using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ServerCafe.Models
{
    [Table("NoiIn")]
    [DataContract(IsReference =true)]
    public class NoiIn
    {
        [Key]
        [DataMember]
        public string IDNoiIn { get; set; }
        [DataMember]
        public string TenNoiIn { get; set; }
        [IgnoreDataMember]
        public virtual ICollection<DoUong> DoUongs { get; set; }
    }
}