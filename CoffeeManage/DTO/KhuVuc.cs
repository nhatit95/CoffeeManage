using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManage.DTO
{
    public class KhuVuc
    {
        public string IDKhuVuc { get; set; }
        public string TenKhuVuc { get; set; }
        public virtual ICollection<Ban> Bans { get; set; }
    }
}
