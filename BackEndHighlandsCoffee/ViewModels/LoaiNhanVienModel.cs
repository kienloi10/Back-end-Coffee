using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using apiModel;

namespace BackEndHighlandsCoffee.ViewModels
{
    public class LoaiNhanvien_model
    {
        public int Id { get; set; }

        public string TenLoai { get; set; }
        public string CongViec { get; set; }
        public LoaiNhanvien_model()
        {

        }
        public LoaiNhanvien_model(LoaiNhanVien lnv)
        {
            this.Id = lnv.Id;
            this.TenLoai = lnv.TenLoai;
            this.CongViec = lnv.CongViec;
        }
        public class TaoLoaiNhanVien
        {
            public string TenLoai { get; set; }
            public string CongViec { get; set; }
        }
        public class CapNhatLoaiNhanVien : TaoLoaiNhanVien
        {
            public int Id { get; set; }
        }
        public class XoaNhanVien : CapNhatLoaiNhanVien
        {

        }

    }


}