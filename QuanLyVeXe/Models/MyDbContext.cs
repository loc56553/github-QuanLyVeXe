using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyVeXe.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }
        DbSet<Xe> Xes { get; set; }
        DbSet<VeXe> VeXes { get; set; }
        DbSet<ThongTinChuyenDi> ThongTinChuyenDis { get; set; }
        DbSet<TaiKhoan> TaiKhoans { get; set; }
        DbSet<NhanVien> NhanViens { get; set; }
        DbSet<LoaiXe> LoaiXes { get; set; }
        DbSet<KhachHang> KhachHangs { get; set; }
        DbSet<ChuyenDi> ChuyenDis { get; set; }
    }
}
