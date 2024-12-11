using System;
using System.Collections.Generic;

namespace QLHS.Model.Entities
{
    public partial class HoSo
    {
        public int MaHoSo { get; set; }
        public string? TenHoSo { get; set; }
        public int? MaSinhVien { get; set; }
        public string? TrangThaiHoSo { get; set; }
        public string? SoYeuLyLich { get; set; }
        public string? GiayKhaiSinh { get; set; }
        public string? Anh { get; set; }
        public string? Cccd { get; set; }
        public string? BangTotNghiepThpt { get; set; }
        public string? GiayToUuTien { get; set; }

        public virtual SinhVien? MaSinhVienNavigation { get; set; }
    }
}
