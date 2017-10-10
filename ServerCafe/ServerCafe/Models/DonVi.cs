using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ServerCafe.Models
{
    [Table("DonVi")]
    [DataContract(IsReference = true)]
    public class DonVi
    {
        [Key]
        [DataMember]
        public string IDDonVi { get; set; }
        [DataMember]
        public string TenDonVi { get; set; }
    }
}