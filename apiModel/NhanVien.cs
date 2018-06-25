using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace apiModel
{
    public class NhanVien:Entity<int>
    {
        public int NhanVienId { get; set; }
        public string HoTen { get; set; }
        
        public string DiaChi { get; set; }
        public DateTime NgaySinh { get; set; }
        public Boolean GioiTinh { get; set; }

        public virtual ICollection<HoaDon> dshd { get; set; }
        
        public virtual LoaiNhanVien LoaiNhanVien { get; set; }
        public virtual ChiNhanh ChiNhanh { get; set; }
    }
}
