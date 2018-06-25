using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using apiModel;

namespace BackEndHighlandsCoffee.ViewModels
{
    public class ChiTietHoaDon_model
    {
        public int Id { get; set; }
        public int SoLuong { get; set; }
        public float DonGia { get; set; }
        public int HoaDonId { get; set; }
        public int SanPhamId { get; set; }

        public ChiTietHoaDon_model()
        {

        }
        public ChiTietHoaDon_model(ChiTietHoaDon cthd)
        {
            this.Id = cthd.Id;
            this.SoLuong = cthd.SoLuong;
            this.DonGia = cthd.DonGia;
            this.HoaDonId = cthd.HoaDon.Id;
            this.SanPhamId = cthd.SanPham.Id;
           

        }
        public class TaoChiTietHoaDon
        {
            public int SoLuong { get; set; }
            public float DonGia { get; set; }
            public int HoaDonId { get; set; }
            public int SanPhamId { get; set; }

        }
        public class CapNhatChiTietHoaDon : TaoChiTietHoaDon
        {
            public int Id { get; set; }
        }
        public class XoaChiTietHoaDon : CapNhatChiTietHoaDon
        {

        }

    }


}