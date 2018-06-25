using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace apiModel
{
   public class ChiNhanh:Entity<int>
    {
        public int ChiNhanhId { get; set; }
        public string TenChiNhanh { get; set; }
        public string DiaChi { get; set; }
        public DateTime NgayThanhLap { get; set; }

        public virtual ICollection<NhanVien> dsnv { get; set; }

        public virtual ICollection<HoaDon> dshd { get; set; }


    }
}
