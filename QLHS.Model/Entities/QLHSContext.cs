using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace QLHS.Model.Entities
{
    public partial class QLHSContext : DbContext
    {
        public QLHSContext()
        {
        }

        public QLHSContext(DbContextOptions<QLHSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bhyt> Bhyts { get; set; } = null!;
        public virtual DbSet<ChungChi> ChungChis { get; set; } = null!;
        public virtual DbSet<DiemHocTap> DiemHocTaps { get; set; } = null!;
        public virtual DbSet<HoSo> HoSos { get; set; } = null!;
        public virtual DbSet<NhanVien> NhanViens { get; set; } = null!;
        public virtual DbSet<PhieuKhenThuongKyLuat> PhieuKhenThuongKyLuats { get; set; } = null!;
        public virtual DbSet<PhieuRenLuyen> PhieuRenLuyens { get; set; } = null!;
        public virtual DbSet<SinhVien> SinhViens { get; set; } = null!;
        public virtual DbSet<ThongTinHocTap> ThongTinHocTaps { get; set; } = null!;
        public virtual DbSet<TieuChiRenLuyen> TieuChiRenLuyens { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-UJ8OJHF; Database=QLHS; Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bhyt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BHYT");

                entity.Property(e => e.MaSoBhyt)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("MaSoBHYT");

                entity.Property(e => e.NoiDangKyKhamChuaBenhBanDau)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.MaSinhVienNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.MaSinhVien)
                    .HasConstraintName("FK__BHYT__MaSinhVien__3B75D760");
            });

            modelBuilder.Entity<ChungChi>(entity =>
            {
                entity.HasKey(e => e.MaChungChi)
                    .HasName("PK__ChungChi__BD2C8F3909A054F5");

                entity.ToTable("ChungChi");

                entity.Property(e => e.MaChungChi).ValueGeneratedNever();

                entity.Property(e => e.TenChungChi)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.XepLoai)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.MaSinhVienNavigation)
                    .WithMany(p => p.ChungChis)
                    .HasForeignKey(d => d.MaSinhVien)
                    .HasConstraintName("FK__ChungChi__MaSinh__4222D4EF");
            });

            modelBuilder.Entity<DiemHocTap>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DiemHocTap");

                entity.Property(e => e.KyHoc)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MaHocPhan)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NamHoc)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TbchocPhan).HasColumnName("TBCHocPhan");

                entity.Property(e => e.TenHocPhan)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.MaSinhVienNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.MaSinhVien)
                    .HasConstraintName("FK__DiemHocTa__MaSin__3F466844");
            });

            modelBuilder.Entity<HoSo>(entity =>
            {
                entity.HasKey(e => e.MaHoSo)
                    .HasName("PK__HoSo__1666423CBA6FDADB");

                entity.ToTable("HoSo");

                entity.Property(e => e.MaHoSo).ValueGeneratedNever();

                entity.Property(e => e.Anh)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BangTotNghiepThpt)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("BangTotNghiepTHPT");

                entity.Property(e => e.Cccd)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("CCCD");

                entity.Property(e => e.GiayKhaiSinh)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.GiayToUuTien)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SoYeuLyLich)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TenHoSo)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TrangThaiHoSo)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.MaSinhVienNavigation)
                    .WithMany(p => p.HoSos)
                    .HasForeignKey(d => d.MaSinhVien)
                    .HasConstraintName("FK__HoSo__MaSinhVien__398D8EEE");
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.HasKey(e => e.MaNhanVien)
                    .HasName("PK__NhanVien__77B2CA4710ED6BA7");

                entity.ToTable("NhanVien");

                entity.Property(e => e.MaNhanVien).ValueGeneratedNever();

                entity.Property(e => e.TenNhanVien)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PhieuKhenThuongKyLuat>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PhieuKhenThuongKyLuat");

                entity.Property(e => e.KetQuaKtkl)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("KetQuaKTKL");

                entity.Property(e => e.KyHoc)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NamHoc)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.MaSinhVienNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.MaSinhVien)
                    .HasConstraintName("FK__PhieuKhen__MaSin__4AB81AF0");
            });

            modelBuilder.Entity<PhieuRenLuyen>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PhieuRenLuyen");

                entity.Property(e => e.KyHoc)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NamHoc)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.XepLoai)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.MaSinhVienNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.MaSinhVien)
                    .HasConstraintName("FK__PhieuRenL__MaSin__47DBAE45");

                entity.HasOne(d => d.MaTieuChiNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.MaTieuChi)
                    .HasConstraintName("FK__PhieuRenL__MaTie__48CFD27E");
            });

            modelBuilder.Entity<SinhVien>(entity =>
            {
                entity.HasKey(e => e.MaSinhVien)
                    .HasName("PK__SinhVien__939AE7758DAF8EE1");

                entity.ToTable("SinhVien");

                entity.Property(e => e.MaSinhVien).ValueGeneratedNever();

                entity.Property(e => e.Cccd)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("CCCD");

                entity.Property(e => e.DanToc)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DangVienDoanVien)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DiaChiNoiNgoaiTru)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DiaChiThuongTru)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.GioiTinh)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HanhKiemLop12)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HoTen)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HoTenBo)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HoTenMe)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Khoa)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Lop)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MaBhyt)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("MaBHYT");

                entity.Property(e => e.NgaySinh).HasColumnType("date");

                entity.Property(e => e.NgaySinhBo).HasColumnType("date");

                entity.Property(e => e.NgaySinhMe).HasColumnType("date");

                entity.Property(e => e.NgayVaoDangDoan).HasColumnType("date");

                entity.Property(e => e.NoiSinh)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.QuocTich)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TonGiao)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TrangThaiSinhVien)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ThongTinHocTap>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ThongTinHocTap");

                entity.Property(e => e.ChuyenNganh)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HeDaoTao)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.KhoaHoc)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.KhoaTuyenSinh)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.MaSinhVienNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.MaSinhVien)
                    .HasConstraintName("FK__ThongTinH__MaSin__3D5E1FD2");
            });

            modelBuilder.Entity<TieuChiRenLuyen>(entity =>
            {
                entity.HasKey(e => e.MaTieuChi)
                    .HasName("PK__TieuChiR__41F85A355E0E7FF8");

                entity.ToTable("TieuChiRenLuyen");

                entity.Property(e => e.MaTieuChi).ValueGeneratedNever();

                entity.Property(e => e.NoiDungTieuChi)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TenTieuChi)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Permission)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
