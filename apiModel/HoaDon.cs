using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace apiModel
{
    public class HoaDon : Entity<int>
    {
        public int HoaDonId { get; set; }
        public DateTime NgayLap { get; set; }
        public float TongTriGia{get;set;}
        //public virtual ChiTietHoaDon cthd { get; set; }
        public virtual ChiNhanh ChiNhanh { get; set; }
        public virtual NhanVien NhanVien { get; set; }
    }
}
