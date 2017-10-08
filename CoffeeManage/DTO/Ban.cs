using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManage.DTO
{
    public class Ban
    {
        public string IDBan { get; set; }
        public string TenBan { get; set; }
        public string IDKhuVuc { get; set; }
        public virtual KhuVuc KhuVuc { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
