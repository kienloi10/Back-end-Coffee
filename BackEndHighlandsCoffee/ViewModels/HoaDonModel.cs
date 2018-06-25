using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using apiModel;

namespace BackEndHighlandsCoffee.ViewModels
{
    public class HoaDon_model
    {
        public int Id { get; set; }
        public float TongGiaTri { get; set; }
        public DateTime NgayLap { get; set; }

        public int ChiNhanhId { get; set; }
        public int NhanVienId { get; set; }

        public HoaDon_model()
        {

        }
        public HoaDon_model(HoaDon hd)
        {
            this.Id = hd.Id;
            this.NgayLap = hd.NgayLap;
            this.TongGiaTri = hd.TongTriGia;
            this.ChiNhanhId = hd.ChiNhanh.Id;
            this.NhanVienId = hd.NhanVien.Id;

        }
        public class TaoHoaDon
        {
            public float TongGiaTri { get; set; }
            public DateTime NgayLap { get; set; }

            public int ChiNhanhId { get; set; }
            public int NhanVienId { get; set; }
        }
        public class CapNhatHoaDon : TaoHoaDon
        {
            public int Id { get; set; }
        }
        public class XoaHoaDon : CapNhatHoaDon
        {

        }

    }


}