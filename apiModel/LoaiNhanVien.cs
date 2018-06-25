using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace apiModel
{
    public class LoaiNhanVien:Entity<int>
    {
        public int LoaiNhanVienId { get; set; }
        public string TenLoai { get; set; }
        public string CongViec { get; set; }
        public virtual ICollection<NhanVien> dsnv { get; set; }
    }
}
