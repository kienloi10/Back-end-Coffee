using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace apiModel
{
    public class ApiDbContext :DbContext
    {
        public ApiDbContext() : base("HighlandsCoffeeEntities")
        {

        }
        static ApiDbContext()
        {
            Database.SetInitializer<ApiDbContext>(new IdentityDbInit());
        }

        public static ApiDbContext create()
        {
            return new ApiDbContext();
        }
        public DbSet<ChiNhanh> ChiNhanhs { get; set; }
        public DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<LoaiNhanVien> LoaiNhanViens { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<NhapSanPham> NhapSanPhams { get; set; }
        public DbSet<SanPham> SanPhams { get; set; }
        public override int SaveChanges()
        {

            return base.SaveChanges();
        }
        internal class IdentityDbInit : DropCreateDatabaseIfModelChanges<ApiDbContext>
        {
            public void Seed(ApiDbContext context)
            {
                PerformInit();
                base.Seed(context);
            }

            public void PerformInit()
            {

            }
        }
        


        
    }
}
