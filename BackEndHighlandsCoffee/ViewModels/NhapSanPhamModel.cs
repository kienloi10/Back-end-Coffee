using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using apiModel;

namespace BackEndHighlandsCoffee.ViewModels
{
    public class NhapSanPham_model
    {
        public int Id { get; set; }
        public int SoLuong { get; set; }
        public DateTime NgayNhap { get; set; }
        public float GiaNhap { get; set; }

        public int ChiNhanhId { get; set; }
        public int  SanPhamId { get; set; }

        public NhapSanPham_model()
        {

        }
        public NhapSanPham_model(NhapSanPham nsp)
        {
            this.Id =nsp.Id;
            this.SoLuong = nsp.SoLuong;
            this.NgayNhap = nsp.NgayNhap;
            this.GiaNhap = nsp.GiaNhap;
            this.ChiNhanhId = nsp.ChiNhanh.Id;
            this.SanPhamId = nsp.SanPham.Id;
        }
        public class TaoNhapSanPham
        {
            public int SoLuong { get; set; }
            public DateTime NgayNhap { get; set; }
            public float GiaNhap { get; set; }

            public int ChiNhanhId { get; set; }
            public int SanPhamId { get; set; }
        }
        public class CapNhatNhapSanPham : TaoNhapSanPham
        {
            public int Id { get; set; }
        }
        public class XoaNhapSanPham : CapNhatNhapSanPham
        {

        }

    }


}