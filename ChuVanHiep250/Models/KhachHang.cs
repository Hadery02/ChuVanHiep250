using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChuVanHiep250.Models;
[Table("Khach Hang")]
public class KhachHang
{
    [Key]
    [Display (Name ="Mã Khách Hàng")]
    public int MaKhachHang { get; set; }
    [Display (Name ="Tên Khách Hàng")]
    public string TenKhachHang { get; set; }
    [Display (Name ="Tên LapTop")]
    public string TenLapTop { get; set; }
    [ForeignKey("TenLapTop")]
    public LapTop? LapTop { get; set; }

}