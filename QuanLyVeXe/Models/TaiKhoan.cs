using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyVeXe.Models
{
    [Table("TaiKhoan")]
    public class TaiKhoan
    {
        [Display(Name ="STT")]
        [Key]
        public long ID { get; set; }
        [Display(Name = "Tên Đăng Nhập")]       
        public string MasoNV { get; set; }
        public string Token { get; set; }   
        [Display(Name ="Mật khẩu")]
        public string MatKhau { get; set; }
        [Display(Name ="Chức Vụ")]
        public string ChucVu { get; set; }
    }
}
