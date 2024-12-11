using System;
using System.Collections.Generic;

namespace QLHS.Model.Entities
{
    public partial class SinhVien
    {
        public SinhVien()
        {
            ChungChis = new HashSet<ChungChi>();
            HoSos = new HashSet<HoSo>();
        }

        public int MaSinhVien { get; set; }
        public string? HoTen { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string? QuocTich { get; set; }
        public string? DanToc { get; set; }
        public string? TonGiao { get; set; }
        public string? GioiTinh { get; set; }
        public string? Cccd { get; set; }
        public string? DiaChiThuongTru { get; set; }
        public string? NoiSinh { get; set; }
        public string? DangVienDoanVien { get; set; }
        public DateTime? NgayVaoDangDoan { get; set; }
        public double? HocLucLop12 { get; set; }
        public string? HanhKiemLop12 { get; set; }
        public string? MaBhyt { get; set; }
        public string? HoTenBo { get; set; }
        public DateTime? NgaySinhBo { get; set; }
        public string? HoTenMe { get; set; }
        public DateTime? NgaySinhMe { get; set; }
        public string? Lop { get; set; }
        public string? Khoa { get; set; }
        public string? DiaChiNoiNgoaiTru { get; set; }
        public string? TrangThaiSinhVien { get; set; }

        public virtual ICollection<ChungChi> ChungChis { get; set; }
        public virtual ICollection<HoSo> HoSos { get; set; }
    }
}
