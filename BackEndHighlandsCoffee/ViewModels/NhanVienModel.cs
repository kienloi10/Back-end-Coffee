using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using apiModel;

namespace BackEndHighlandsCoffee.ViewModels
{
    public class NhanVien_model
    {
        public int Id { get; set; }
        public string HoTen { get; set; }

        public string DiaChi { get; set; }
        public DateTime NgaySinh { get; set; }
        public Boolean GioiTinh { get; set; }

       public int LoaiNhanVienId { get; set; }
        public int ChiNhanhId { get; set; }

        public NhanVien_model()
        {

        }
        public NhanVien_model(NhanVien nv)
        {
            this.Id = nv.Id;
            this.HoTen = nv.HoTen;
            this.DiaChi = nv.DiaChi;
            this.NgaySinh = nv.NgaySinh;
            this.GioiTinh = nv.GioiTinh;
            this.LoaiNhanVienId = nv.LoaiNhanVien.Id;
        }
        public class TaoNhanVien
        {
           
            public string HoTen { get; set; }

            public string DiaChi { get; set; }
            public DateTime NgaySinh { get; set; }
            public Boolean GioiTinh { get; set; }

            public int LoaiNhanVienId { get; set; }
            public int ChiNhanhId { get; set; }
        }
        public class CapNhatNhanVien : TaoNhanVien
        {
            public int Id { get; set; }
        }
        public class XoaNhanVien : CapNhatNhanVien
        {

        }

    }
   

}