using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyVeXe.Models
{
    [Table("KhachHang")]
    public class KhachHang
    {
        [Display(Name ="STT")]
        public long ID { get; set; }
        [Key]
        [Display(Name ="Mã Số Khách Hàng")]
        public string MSKH { get; set; }
        [Display(Name = "Tên Khách Hàng")]
        [Required]
        [MaxLength(50,ErrorMessage ="Tối Đa 50 Ký Tự")]
        public string TenKH { get; set; }
        [MaxLength(50,ErrorMessage ="")]
        public string SDT { get; set; }
        public DateTime NamSinh { get; set; }
    }
}
