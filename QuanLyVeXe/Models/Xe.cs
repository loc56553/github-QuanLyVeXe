using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyVeXe.Models
{
    [Table("Xe")]
    public class Xe
    {
        [Display(Name ="STT")]
        public long ID { get; set; }
        [Key]
        [Display(Name = "Biển Số Xe")]
        [Required]
        public string BienSo { get; set; }
        [Display(Name = "Tên Loại Xe")]
        public string TenLoaiXe { get; set; }
        [Display(Name ="Số Ghế Trên Xe")]
        public int SoGheXe { get; set; }
    }
}
