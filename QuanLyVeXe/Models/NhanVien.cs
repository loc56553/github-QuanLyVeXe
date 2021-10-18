using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyVeXe.Models
{
    [Table("NhanVien")]
    public class NhanVien
    {
        [Display(Name ="STT")]
        public long ID { get; set; }
        public string Image { get; set; }
        [Key]
        [Display(Name ="Mã Số Nhân Viên")]
        public string MSNV { get; set; }
        [Required]
        [Display(Name ="Tên Nhân Viên")]
        [MaxLength(50,ErrorMessage ="Tối Đa 50 Ký Tự")]
        public string TenNV { get; set; }
        [Display(Name = "Địa Chỉ")]
        [MaxLength(50, ErrorMessage = "Tối Đa 50 Ký Tự")]
        public string Diachi { get; set; }
        [Display(Name = "Email")]
        [MaxLength(50, ErrorMessage = "Tối Đa 50 Ký Tự")]
        public string Email { get; set; }
        [Display(Name = "Số Điện Thoại")]
        public string SDT { get; set; }
        [Display(Name ="CMND")]
        public string CMND { get; set; }
    }
}
