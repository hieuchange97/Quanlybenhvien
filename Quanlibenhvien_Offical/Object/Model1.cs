namespace Quanlibenhvien_Offical.Object
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model121")
        {
        }

        public virtual DbSet<BENHAN> BENHANs { get; set; }
        public virtual DbSet<BENHNHAN> BENHNHANs { get; set; }
        public virtual DbSet<BENHNHANLAMVIEC> BENHNHANLAMVIECs { get; set; }
        public virtual DbSet<BHYT> BHYTs { get; set; }
        public virtual DbSet<CHITIETDONTHUOC> CHITIETDONTHUOCs { get; set; }
        public virtual DbSet<CHUCVU> CHUCVUs { get; set; }
        public virtual DbSet<DICHVU> DICHVUs { get; set; }
        public virtual DbSet<DONTHUOC> DONTHUOCs { get; set; }
        public virtual DbSet<DTUT> DTUTs { get; set; }
        public virtual DbSet<GIAYCHUYENVIEN> GIAYCHUYENVIENs { get; set; }
        public virtual DbSet<KHOA> KHOAs { get; set; }
        public virtual DbSet<LOAIHINHDIEUTRI> LOAIHINHDIEUTRIs { get; set; }
        public virtual DbSet<LOAIPHIEUXETNGHIEM> LOAIPHIEUXETNGHIEMs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<NHANVIENLAMVIEC> NHANVIENLAMVIECs { get; set; }
        public virtual DbSet<PHANQUYEN> PHANQUYENs { get; set; }
        public virtual DbSet<PHIEUHENKHAMLAI> PHIEUHENKHAMLAIs { get; set; }
        public virtual DbSet<PHIEUKHAMBENH> PHIEUKHAMBENHs { get; set; }
        public virtual DbSet<PHIEUTHANHTOANXNKT> PHIEUTHANHTOANXNKTs { get; set; }
        public virtual DbSet<PHIEUXETNGHIEM> PHIEUXETNGHIEMs { get; set; }
        public virtual DbSet<PHONGBAN> PHONGBANs { get; set; }
        public virtual DbSet<PHONGBANDICHVU> PHONGBANDICHVUs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TAIKHOAN> TAIKHOANs { get; set; }
        public virtual DbSet<THUOC> THUOCs { get; set; }
        public virtual DbSet<TRANGTHAILAMVIEC> TRANGTHAILAMVIECs { get; set; }
        public virtual DbSet<TUYENBHYT> TUYENBHYTs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BENHAN>()
                .Property(e => e.IDba)
                .IsUnicode(false);

            modelBuilder.Entity<BENHAN>()
                .Property(e => e.IDloaihinh)
                .IsUnicode(false);

            modelBuilder.Entity<BENHAN>()
                .Property(e => e.IDbn)
                .IsUnicode(false);

            modelBuilder.Entity<BENHAN>()
                .HasMany(e => e.PHIEUKHAMBENHs)
                .WithRequired(e => e.BENHAN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BENHNHAN>()
                .Property(e => e.IDbn)
                .IsUnicode(false);

            modelBuilder.Entity<BENHNHAN>()
                .Property(e => e.Sdt)
                .IsUnicode(false);

            modelBuilder.Entity<BENHNHAN>()
                .Property(e => e.CMTND)
                .IsUnicode(false);

            modelBuilder.Entity<BENHNHAN>()
                .Property(e => e.Giaykhaisinh)
                .IsUnicode(false);

            modelBuilder.Entity<BENHNHAN>()
                .HasMany(e => e.BENHANs)
                .WithRequired(e => e.BENHNHAN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BENHNHAN>()
                .HasMany(e => e.BENHNHANLAMVIECs)
                .WithRequired(e => e.BENHNHAN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BENHNHANLAMVIEC>()
                .Property(e => e.IDbnlv)
                .IsUnicode(false);

            modelBuilder.Entity<BENHNHANLAMVIEC>()
                .Property(e => e.IDbn)
                .IsUnicode(false);

            modelBuilder.Entity<BENHNHANLAMVIEC>()
                .Property(e => e.IDpb)
                .IsUnicode(false);

            modelBuilder.Entity<BENHNHANLAMVIEC>()
                .Property(e => e.IDba)
                .IsUnicode(false);

            modelBuilder.Entity<BENHNHANLAMVIEC>()
                .Property(e => e.IDtrangthai)
                .IsUnicode(false);

            modelBuilder.Entity<BENHNHANLAMVIEC>()
                .Property(e => e.IDnv)
                .IsUnicode(false);

            modelBuilder.Entity<BHYT>()
                .Property(e => e.IDbhyt)
                .IsUnicode(false);

            modelBuilder.Entity<BHYT>()
                .Property(e => e.IDtuyen)
                .IsUnicode(false);

            modelBuilder.Entity<BHYT>()
                .Property(e => e.IDbn)
                .IsUnicode(false);

            modelBuilder.Entity<BHYT>()
                .HasMany(e => e.GIAYCHUYENVIENs)
                .WithRequired(e => e.BHYT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CHITIETDONTHUOC>()
                .Property(e => e.IDdonthuoc)
                .IsUnicode(false);

            modelBuilder.Entity<CHITIETDONTHUOC>()
                .Property(e => e.IDthuoc)
                .IsUnicode(false);

            modelBuilder.Entity<CHUCVU>()
                .Property(e => e.IDchucvu)
                .IsUnicode(false);

            modelBuilder.Entity<DICHVU>()
                .Property(e => e.IDdichvu)
                .IsUnicode(false);

            modelBuilder.Entity<DICHVU>()
                .HasMany(e => e.PHONGBANDICHVUs)
                .WithRequired(e => e.DICHVU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DONTHUOC>()
                .Property(e => e.IDdonthuoc)
                .IsUnicode(false);

            modelBuilder.Entity<DONTHUOC>()
                .Property(e => e.IDba)
                .IsUnicode(false);

            modelBuilder.Entity<DONTHUOC>()
                .Property(e => e.IDnv)
                .IsUnicode(false);

            modelBuilder.Entity<DONTHUOC>()
                .HasMany(e => e.CHITIETDONTHUOCs)
                .WithRequired(e => e.DONTHUOC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GIAYCHUYENVIEN>()
                .Property(e => e.IDgcv)
                .IsUnicode(false);

            modelBuilder.Entity<GIAYCHUYENVIEN>()
                .Property(e => e.IDbhyt)
                .IsUnicode(false);

            modelBuilder.Entity<KHOA>()
                .Property(e => e.IDkhoa)
                .IsUnicode(false);

            modelBuilder.Entity<KHOA>()
                .Property(e => e.IDtruongkhoa)
                .IsUnicode(false);

            modelBuilder.Entity<KHOA>()
                .HasMany(e => e.NHANVIENs)
                .WithOptional(e => e.KHOA)
                .HasForeignKey(e => e.IDkhoa);

            modelBuilder.Entity<LOAIHINHDIEUTRI>()
                .Property(e => e.IDloaihinh)
                .IsUnicode(false);

            modelBuilder.Entity<LOAIPHIEUXETNGHIEM>()
                .Property(e => e.IDloai)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.IDnv)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.Sđt)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.IDchucvu)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.IDtk)
                .IsFixedLength();

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.IDkhoa)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.KHOAs)
                .WithOptional(e => e.NHANVIEN)
                .HasForeignKey(e => e.IDtruongkhoa);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.NHANVIENLAMVIECs)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.PHIEUTHANHTOANXNKTs)
                .WithOptional(e => e.NHANVIEN)
                .HasForeignKey(e => e.IDnv);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.PHIEUTHANHTOANXNKTs1)
                .WithOptional(e => e.NHANVIEN1)
                .HasForeignKey(e => e.IDnvthungan);

            modelBuilder.Entity<NHANVIENLAMVIEC>()
                .Property(e => e.IDnvlv)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIENLAMVIEC>()
                .Property(e => e.IDnv)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIENLAMVIEC>()
                .Property(e => e.IDpb)
                .IsUnicode(false);

            modelBuilder.Entity<PHANQUYEN>()
                .Property(e => e.IDquyen)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUHENKHAMLAI>()
                .Property(e => e.IDphieuhen)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUHENKHAMLAI>()
                .Property(e => e.IDnv)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUHENKHAMLAI>()
                .Property(e => e.IDba)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUKHAMBENH>()
                .Property(e => e.IDpk)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUKHAMBENH>()
                .Property(e => e.giolap)
                .HasPrecision(6);

            modelBuilder.Entity<PHIEUKHAMBENH>()
                .Property(e => e.ChuandoanCLS)
                .IsFixedLength();

            modelBuilder.Entity<PHIEUKHAMBENH>()
                .Property(e => e.IDba)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUKHAMBENH>()
                .Property(e => e.IDnv)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUTHANHTOANXNKT>()
                .Property(e => e.IDpttxn)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUTHANHTOANXNKT>()
                .Property(e => e.IDdichvu)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUTHANHTOANXNKT>()
                .Property(e => e.giolap)
                .HasPrecision(6);

            modelBuilder.Entity<PHIEUTHANHTOANXNKT>()
                .Property(e => e.IDnv)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUTHANHTOANXNKT>()
                .Property(e => e.IDba)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUTHANHTOANXNKT>()
                .Property(e => e.IDbnlv)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUTHANHTOANXNKT>()
                .Property(e => e.IDnvthungan)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUTHANHTOANXNKT>()
                .HasMany(e => e.PHIEUXETNGHIEMs)
                .WithRequired(e => e.PHIEUTHANHTOANXNKT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHIEUXETNGHIEM>()
                .Property(e => e.IDpxn)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUXETNGHIEM>()
                .Property(e => e.IDnv)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUXETNGHIEM>()
                .Property(e => e.IDpb)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUXETNGHIEM>()
                .Property(e => e.IDloai)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUXETNGHIEM>()
                .Property(e => e.IDpttxn)
                .IsUnicode(false);

            modelBuilder.Entity<PHONGBAN>()
                .Property(e => e.IDpb)
                .IsUnicode(false);

            modelBuilder.Entity<PHONGBAN>()
                .Property(e => e.IDpbCha)
                .IsUnicode(false);

            modelBuilder.Entity<PHONGBAN>()
                .Property(e => e.IDkhoa)
                .IsUnicode(false);

            modelBuilder.Entity<PHONGBAN>()
                .HasMany(e => e.NHANVIENLAMVIECs)
                .WithRequired(e => e.PHONGBAN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHONGBAN>()
                .HasMany(e => e.PHONGBAN1)
                .WithOptional(e => e.PHONGBAN2)
                .HasForeignKey(e => e.IDpbCha);

            modelBuilder.Entity<PHONGBAN>()
                .HasMany(e => e.PHONGBANDICHVUs)
                .WithRequired(e => e.PHONGBAN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHONGBANDICHVU>()
                .Property(e => e.IDpb)
                .IsUnicode(false);

            modelBuilder.Entity<PHONGBANDICHVU>()
                .Property(e => e.IDdichvu)
                .IsUnicode(false);

            modelBuilder.Entity<TAIKHOAN>()
                .Property(e => e.IDtk)
                .IsUnicode(false);

            modelBuilder.Entity<TAIKHOAN>()
                .Property(e => e.Tendn)
                .IsUnicode(false);

            modelBuilder.Entity<TAIKHOAN>()
                .Property(e => e.Matkhau)
                .IsUnicode(false);

            modelBuilder.Entity<TAIKHOAN>()
                .Property(e => e.IDnv)
                .IsUnicode(false);

            modelBuilder.Entity<TAIKHOAN>()
                .Property(e => e.IDquyen)
                .IsUnicode(false);

            modelBuilder.Entity<THUOC>()
                .Property(e => e.IDthuoc)
                .IsUnicode(false);

            modelBuilder.Entity<THUOC>()
                .HasMany(e => e.CHITIETDONTHUOCs)
                .WithRequired(e => e.THUOC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TRANGTHAILAMVIEC>()
                .Property(e => e.IDtrangthai)
                .IsUnicode(false);

            modelBuilder.Entity<TUYENBHYT>()
                .Property(e => e.IDtuyen)
                .IsUnicode(false);
        }
    }
}
