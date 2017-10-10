using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ServerCafe.Models
{
    [Table("Order")]
    [DataContract(IsReference = true)]
    public class Order
    {
        [Key]
        [DataMember]
        public string IDOrder { get; set; }
        [DataMember]
        public string IDBan { get; set; }
        [ForeignKey("IDBan")]
        [DataMember]
        public virtual Ban Ban { get; set; }
        [DataMember]
        public string IDThongTinCaNhan { get; set; }
        [ForeignKey("IDThongTinCaNhan")]
        [DataMember]
        public virtual ThongTinCaNhan ThongTinCaNhan { get; set; }
        [DataMember]
        public string ThoiGianVao { get; set; }
        [DataMember]
        public string ThoiGianRa { get; set; }
        [DataMember]
        public bool DaThanhToan { get; set; }
        [DataMember]
        public int PhuThu { get; set; }
        [DataMember]
        public string GhiChu { get; set; }
        [DataMember]
        public virtual ICollection<ChiTietOrder> ChiTietOrders { get; set; }


    }
}
     