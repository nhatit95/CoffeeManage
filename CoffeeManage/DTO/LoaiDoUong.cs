using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManage.DTO
{
    public class LoaiDoUong
    {
        public string IDLoaiDoUong { get; set; }
        public string TenLoaiDoUong { get; set; }
        public virtual ICollection<DoUong> DoUongs { get; set; }
    }
}
