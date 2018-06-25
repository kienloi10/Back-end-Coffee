using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using apiModel;

namespace BackEndHighlandsCoffee.ViewModels
{
    public class ChiNhanhModel
    {
        public int Id { get; set; }
        public int ChiNhanhId { get; set; }
        public string TenChiNhanh { get; set; }
        public string DiaChi { get; set; }
        public DateTime NgayThanhLap { get; set; }

        public ChiNhanhModel()
        {

        }
        public ChiNhanhModel(ChiNhanh cn)
        {
            this.Id = cn.Id;
            this.ChiNhanhId = cn.ChiNhanhId;
            this.TenChiNhanh = cn.TenChiNhanh;
            this.DiaChi = cn.DiaChi;
            this.NgayThanhLap = cn.NgayThanhLap;
            
        }
        public class TaoChiNhanh
        {
            public int ChiNhanhId { get; set; }

            public string TenChiNhanh { get; set; }
            public string DiaChi { get; set; }
            public DateTime NgayThanhLap { get; set; }
        }
        public class CapNhatChiNhanh : TaoChiNhanh
        {
            public int Id { get; set; }
        }
        public class XoaChiNhanh : CapNhatChiNhanh
        {

        }

    }


}