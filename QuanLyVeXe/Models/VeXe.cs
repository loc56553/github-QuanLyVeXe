using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyVeXe.Models
{
    [Table("VeXe")]
    public class VeXe
    {
        [Display(Name ="STT")]
        public long ID { get; set; }
        [Key]
        [Display(Name ="Mã Số Vé")]
        public string MSVe { get; set; }
        [Display(Name = "Mã Số Thông Tin Chuyên Đi")]
        public string MSTTChuyenDi { get; set; }
        [Display(Name = "Mã Số Khách Hàng")]
        public string MSKH { get; set; }
        [Display(Name ="Số Ghế Ngồi")]
        public int SoGheKH { get; set; }
    }
}
