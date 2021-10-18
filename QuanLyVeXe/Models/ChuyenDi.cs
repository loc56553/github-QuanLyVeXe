using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyVeXe.Models
{
    [Table("ChuyenDi")]
    public class ChuyenDi
    {
        [Display(Name ="STT")]
        public long ID { get; set; }
        [Key]
        [Display(Name="Mã Số Chuyến Đi")]
        public string MSChuyen { get; set; }
        [Display(Name ="Điểm Đi")]
        [MaxLength(50,ErrorMessage ="Tối Đá 50 Ký Tự")]
        public string DiemDi { get; set; }
        [Display(Name = "Điểm Đến")]
        [MaxLength(50, ErrorMessage = "Tối Đá 50 Ký Tự")]
        public string DiemDen { get; set; }
        [Display(Name = "Ngày Đi")]
        public DateTime NgayDi { get; set; }
        [Display(Name ="Giờ Đi")]
        public DateTime GioDi { get; set; }
        [Display(Name ="Giá Tiến")]
        public double GiaTien { get; set; }

    }
}
