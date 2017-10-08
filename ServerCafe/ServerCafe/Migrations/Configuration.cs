namespace ServerCafe.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ServerCafe.Models.ModelCafe>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ServerCafe.Models.ModelCafe context)
        {
            context.KhuVucs.AddOrUpdate(
                p => p.IDKhuVuc,
                new KhuVuc { IDKhuVuc = "kv1", TenKhuVuc = "A" },
                new KhuVuc { IDKhuVuc = "kv2", TenKhuVuc = "B" }
                );
            context.Bans.AddOrUpdate(
                p => p.IDBan,
                new Ban { IDBan = "A1", TenBan = "A1", IDKhuVuc = "kv1"},
                new Ban { IDBan = "A2", TenBan = "A2", IDKhuVuc = "kv1" },
                new Ban { IDBan = "A3", TenBan = "A3", IDKhuVuc = "kv1"},
                new Ban { IDBan = "B1", TenBan = "B1", IDKhuVuc = "kv2"},
                new Ban { IDBan = "B2", TenBan = "B2", IDKhuVuc = "kv2"},
                new Ban { IDBan = "B3", TenBan = "B3", IDKhuVuc = "kv2"}
                );
            context.NoiIns.AddOrUpdate(
                p => p.IDNoiIn,
                new NoiIn { IDNoiIn = "bep", TenNoiIn = "Bếp" },
                new NoiIn { IDNoiIn = "quay", TenNoiIn = "Quầy" }
                );
            context.LoaiDoUongs.AddOrUpdate(
                p => p.IDLoaiDoUong,
                new LoaiDoUong { IDLoaiDoUong = "dc", TenLoaiDoUong = "Đóng Chai" },
                new LoaiDoUong { IDLoaiDoUong = "pc", TenLoaiDoUong = "Pha Chế" });
            context.DonVis.AddOrUpdate(
               p => p.IDDonVi,
               new DonVi { IDDonVi = "dv1", TenDonVi = "Kg" },
               new DonVi { IDDonVi = "dv2", TenDonVi = "Lít" },
               new DonVi { IDDonVi = "dv3", TenDonVi = "Chai" },
               new DonVi { IDDonVi = "dv4", TenDonVi = "Hộp" }
                );
            context.NguyenLieus.AddOrUpdate(
                p => p.IDNguyenLieu,
                new NguyenLieu { IDNguyenLieu = "nl1", TenNguyenLieu = "Cafe", IDDonVi = "dv1", Gia = 30000, SoLuong = 20 },
                new NguyenLieu { IDNguyenLieu = "nl2", TenNguyenLieu = "Sữa", IDDonVi = "dv2", Gia = 20000, SoLuong = 10 },
                new NguyenLieu { IDNguyenLieu = "nl3", TenNguyenLieu = "Sting Vàng", IDDonVi = "dv3", Gia = 2500, SoLuong = 100 },
                new NguyenLieu { IDNguyenLieu = "nl4", TenNguyenLieu = "Khoáng Lạc Thạch Bích", IDDonVi = "dv4", Gia = 2500, SoLuong = 100 });
            context.DoUongs.AddOrUpdate(
                p => p.IDDoUong,
                new DoUong { IDDoUong = "du1", TenDoUong = "Cafe Sữa", IDLoaiDoUong = "pc", IDNoiIn = "bep", GiaTien = 10000, KhuyenMai = 0 },
                new DoUong { IDDoUong = "du2", TenDoUong = "Khoáng Sữa", IDLoaiDoUong = "pc", IDNoiIn = "bep", GiaTien = 10000, KhuyenMai = 1000 },
                new DoUong { IDDoUong = "du3", TenDoUong = "Sting Vàng", IDLoaiDoUong = "dc", IDNoiIn = "quay", GiaTien = 12000, KhuyenMai = 0 }
                );
            
            context.ThanhPhanDoUongs.AddOrUpdate(
                p => p.IDThanhPhanDoUong,
                new ThanhPhanDoUong { IDThanhPhanDoUong = "tp1", IDDoUong = "du1", IDNguyenLieu = "nl1", SoLuong = 0.1f },
                new ThanhPhanDoUong { IDThanhPhanDoUong = "tp2", IDDoUong = "du1", IDNguyenLieu = "nl2", SoLuong = 0.1f },
                new ThanhPhanDoUong { IDThanhPhanDoUong = "tp3", IDDoUong = "du2", IDNguyenLieu = "nl2", SoLuong = 0.1f },
                new ThanhPhanDoUong { IDThanhPhanDoUong = "tp4", IDDoUong = "du2", IDNguyenLieu = "nl4", SoLuong = 1f },
                new ThanhPhanDoUong { IDThanhPhanDoUong = "tp5", IDDoUong = "du3", IDNguyenLieu = "nl3", SoLuong = 1f });
            context.ChucVus.AddOrUpdate(
                p => p.IDChucVu,
                new ChucVu { IDChucVu = "CQ", TenChucVu = "Chủ Quán", LuongCa = 0 },
                new ChucVu { IDChucVu = "QL", TenChucVu = "Quản Lý", LuongCa = 100000 },
                new ChucVu { IDChucVu = "TN", TenChucVu = "Thu Ngân", LuongCa = 80000 }

                );
            context.ThongTinCaNhans.AddOrUpdate(
                p => p.IDUser,
                new ThongTinCaNhan { IDUser = "Us1", IDChucVu = "CQ", DiaChi = "Đà Nẵng", Email = "toanchuate.tct@gmail.com", NangLucLamViec = 2, NgaySinh = "1/1/1995", SDT = "09090909", Ten = "Trương Công Toàn" },
                new ThongTinCaNhan { IDUser = "Us2", IDChucVu = "QL", DiaChi = "Đà Nẵng", Email = "nhatit1995@gmail.com", NangLucLamViec = 3, NgaySinh = "2/2/1995", SDT = "010101010", Ten = "Nguyễn Văn Nhật" },
                new ThongTinCaNhan { IDUser = "Us3", IDChucVu = "TN", DiaChi = "Đà Nẵng", Email = "lesan1995@gmail.com", NangLucLamViec = 4, NgaySinh = "3/3/1995", SDT = "020202020", Ten = "Lê Quang Tam" });
            context.Orders.AddOrUpdate(
                p => p.IDOrder,
                new Order { IDOrder = "od1", IDBan = "A2", ThoiGianVao = "08/10/2017 08:00:00.00", ThoiGianRa = "00/00/0000 00:00:00.00", IDThongTinCaNhan = "Us3", PhuThu = 0, GhiChu = "", DaThanhToan = false },
                new Order { IDOrder = "od2", IDBan = "A1", ThoiGianVao = "08/09/2017 08:00:00.00", ThoiGianRa = "08/09/2017 09:00:00.00", IDThongTinCaNhan = "Us3", PhuThu = 0, GhiChu = "", DaThanhToan = true },
                new Order { IDOrder = "od3", IDBan = "B1", ThoiGianVao = "08/10/2017 10:00:00.00", ThoiGianRa = "00/00/0000 00:00:00.00", IDThongTinCaNhan = "Us3", PhuThu = 0, GhiChu = "", DaThanhToan = false },
                new Order { IDOrder = "od4", IDBan = "B3", ThoiGianVao = "09/10/2017 09:30:00.00", ThoiGianRa = "00/00/0000 00:00:00.00", IDThongTinCaNhan = "Us3", PhuThu = 10000, GhiChu = "Làm Hư Bàn", DaThanhToan = true }
                );
            context.ChiTietOrders.AddOrUpdate(
                p => p.IDChiTietOrder,
                new ChiTietOrder { IDChiTietOrder = "ct1", IDOrder = "od1", IDDoUong = "du1", SoLuong = 3, GhiChu = "Nhiều Sữa", DaIn = true, ThoiGian = "08/10/2017 08:05:00.00" },
                new ChiTietOrder { IDChiTietOrder = "ct2", IDOrder = "od1", IDDoUong = "du3", SoLuong = 4, GhiChu = "", DaIn = true, ThoiGian = "08/10/2017 08:06:00.00" },
                new ChiTietOrder { IDChiTietOrder = "ct3", IDOrder = "od1", IDDoUong = "du1", SoLuong = 2, GhiChu = "", DaIn = false, ThoiGian = "08/10/2017 08:10:00.00" },
                new ChiTietOrder { IDChiTietOrder = "ct4", IDOrder = "od3", IDDoUong = "du3", SoLuong = 5, GhiChu = "", DaIn = true, ThoiGian = "08/10/2017 10:10.00" },
                new ChiTietOrder { IDChiTietOrder = "ct5", IDOrder = "od4", IDDoUong = "du2", SoLuong = 4, GhiChu = "", DaIn = true, ThoiGian = "09/10/2017 09:35:00.00" },
                new ChiTietOrder { IDChiTietOrder = "ct6", IDOrder = "od4", IDDoUong = "du1", SoLuong = 2, GhiChu = "", DaIn = false, ThoiGian = "09/10/2017 09:40:00.00" }
                );
        }
    }
}
