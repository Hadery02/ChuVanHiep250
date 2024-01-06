using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChuVanHiep250.Models;
[Table("LapTop")]
public class LapTop 
{
    [Key] 
    [Display (Name ="Tên LapTop")]
    public string TenLapTop { get; set; }
     [Display (Name ="Ngày Mua")]
    public DateTime NgayMua { get; set; }
     [Display (Name ="Giá Tiền")]
    public decimal GiaTien { get; set; }

}