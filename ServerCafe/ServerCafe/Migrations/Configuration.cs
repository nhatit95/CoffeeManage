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
            context.NoiIns.AddOrUpdate(
                p => p.IDNoiIn,
                new NoiIn { IDNoiIn = "bep", TenNoiIn = "Bếp" },
                new NoiIn { IDNoiIn = "quay", TenNoiIn = "Quầy" }
                );
            context.LoaiDoUongs.AddOrUpdate(
                p => p.IDLoaiDoUong,
                new LoaiDoUong { IDLoaiDoUong = "dc", TenLoaiDoUong = "Đóng Chai" },
                new LoaiDoUong { IDLoaiDoUong = "pc", TenLoaiDoUong = "Pha Chế" });
            context.NguyenLieus.AddOrUpdate(
                p => p.IDNguyenLieu,
                new NguyenLieu { IDNguyenLieu = "nl1", TenNguyenLieu = "Cafe", DonViTinh = "kg", Gia = 30000, SoLuong = 20 },
                new NguyenLieu { IDNguyenLieu = "nl2", TenNguyenLieu = "Sữa", DonViTinh = "Lít", Gia = 20000, SoLuong = 10 });
            context.DoUongs.AddOrUpdate(
                p => p.IDDoUong,
                new DoUong { IDDoUong = "du1", TenDoUong = "Cafe Sữa", IDLoaiDoUong = "pc", IDNoiIn = "quay", GiaTien = 10000, KhuyenMai = 0}
                );
            context.ThanhPhanDoUongs.AddOrUpdate(
                p => p.IDThanhPhanDoUong,
                new ThanhPhanDoUong { IDThanhPhanDoUong = "tp1", IDDoUong = "du1", IDNguyenLieu = "nl1", SoLuong = 0.1f },
                new ThanhPhanDoUong { IDThanhPhanDoUong = "tp2", IDDoUong = "du1", IDNguyenLieu = "nl2", SoLuong = 0.1f });
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

        }
    }
}
