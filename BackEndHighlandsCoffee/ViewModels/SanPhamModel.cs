using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using apiModel;

namespace BackEndHighlandsCoffee.ViewModels
{
    public class SanPham_model
    {
        public int Id { get; set; }
        public string TenSanPham { get; set; }
        public string MoTa { get; set; }
        public float DonGia { get; set; }

        public SanPham_model()
        {

        }
        public SanPham_model(SanPham sp)
        {
            this.Id = sp.Id;
            this.TenSanPham = sp.TenSanPham;
            this.MoTa = sp.MoTa;
            this.DonGia = sp.DonGia;
        }
        public class TaoSanPham
        {
            public string TenSanPham { get; set; }
            public string MoTa { get; set; }
            public float DonGia { get; set; }
        }
        public class CapNhatSanPham : TaoSanPham
        {
            public int Id { get; set; }
        }
        public class XoaSanPham : CapNhatSanPham
        {

        }

    }


}