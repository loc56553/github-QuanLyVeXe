using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NguyenLoc.Demo1.Models
{
    [Table("NhanVien")]
    public class NhanVien
    {    
        [Key]
        public long MSNV { get; set; }

        public string TenNV { get; set; }

        public string Vitri { get; set; }

        public string Diachi { get; set; }
        public void Update(int id, NhanVien nhanvien)
        {
            this.MSNV = id;
            if (nhanvien.TenNV != null) this.TenNV = nhanvien.TenNV;
            else this.TenNV = this.TenNV;
            if (nhanvien.Vitri != null) this.Vitri = nhanvien.Vitri;
            else this.Vitri = this.Vitri;
            if (nhanvien.Diachi != null) this.Diachi = nhanvien.Diachi;
        }
    }
}
