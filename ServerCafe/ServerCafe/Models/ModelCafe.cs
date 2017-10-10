namespace ServerCafe.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ModelCafe : DbContext
    {
        public DbSet<DonVi> DonVis { get; set; }
        public DbSet<LoaiDoUong> LoaiDoUongs { get; set; }
        public DbSet<NoiIn> NoiIns { get; set; }
        public DbSet<NguyenLieu> NguyenLieus { get; set; }
        public DbSet<ThanhPhanDoUong> ThanhPhanDoUongs { get; set; }

        public DbSet<DoUong> DoUongs { get; set; }
        public DbSet<ChucVu> ChucVus { get; set; }
        public DbSet<ThongTinCaNhan> ThongTinCaNhans { get; set; }
        
        public DbSet<KhuVuc> KhuVucs { get; set; }
        public DbSet<Ban> Bans { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ChiTietOrder> ChiTietOrders { get; set; }
       
        public ModelCafe() : base("name=ModelCafe")
        {

        }

    }
}