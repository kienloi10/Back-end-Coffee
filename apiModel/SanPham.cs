using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace apiModel
{
    public class SanPham:Entity<int>
    {
        public int SanPhamId { get; set; }
        public string TenSanPham { get; set; }
        public string MoTa { get; set; }
        public float DonGia { get; set; }

    }
}
