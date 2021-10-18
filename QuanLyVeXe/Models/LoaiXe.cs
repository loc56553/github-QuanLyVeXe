using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyVeXe.Models
{
    [Table("LoaiXe")]
    public class LoaiXe
    {
        [Display(Name ="STT")]
        public long ID { get; set; }
        [Key]
        [Display(Name ="Mã Loại Xe")]
        [MaxLength(50,ErrorMessage ="Tối Đa 50 Ký Tự")]
        public string MSLoaiXe { get; set; }
        [Display(Name ="Tên Loại Xe")]
        [MaxLength(50,ErrorMessage ="Tối Đa 50 Ký Tự")]
        [Required]
        public string TenLoaiXe { get; set; }
        [Display(Name ="Số Lượng Xe")]
        public int SoLuong { get; set; }
        [Display(Name ="Số ghế")]
        public int SoGhe { get; set; }
    }
}
