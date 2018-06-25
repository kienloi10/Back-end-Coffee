using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
namespace apiModel
{
    public class ChiTietHoaDon:Entity<int>
    {
        public int SoLuong { get; set; }
        public float DonGia { get; set; }
        public virtual SanPham SanPham { get; set; }
        public virtual HoaDon HoaDon { get; set; }
        
    }
}
