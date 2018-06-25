using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace apiModel
{
    public class NhapSanPham:Entity<int>
    {
        public int SoLuong { get; set; }
        public DateTime NgayNhap { get; set; }
        public float GiaNhap { get; set; }
        public virtual ChiNhanh ChiNhanh { get; set; }
        public virtual SanPham SanPham { get; set; }
    }
}
