using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyVeXe.Models
{
    [Table("ThongTinChuyenDi")]
    public class ThongTinChuyenDi
    {
        public long ID { get; set; }
        [Key]
        [Display(Name ="Mã Số Thông Tin Chuyến Đi")]
        public string MSTTChuyenDi { get; set; }
        [Display(Name = "Mã Số Chuyến Đi")]
        public string MSChuyenDi { get; set; }
        [Display(Name ="Biển Số Xe")]
        public string MSXe { get; set; }
        [Display(Name ="Mã Vé Xe")]
        public string MSVe { get; set; }

    }
}
