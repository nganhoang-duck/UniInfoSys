using System;
using System.Collections.Generic;

namespace QLHS.Model.Entities
{
    public partial class PhieuRenLuyen
    {
        public int? MaSinhVien { get; set; }
        public string? KyHoc { get; set; }
        public string? NamHoc { get; set; }
        public int? MaTieuChi { get; set; }
        public double? DiemTieuChi { get; set; }
        public double? TongDiem { get; set; }
        public string? XepLoai { get; set; }

        public virtual SinhVien? MaSinhVienNavigation { get; set; }
        public virtual TieuChiRenLuyen? MaTieuChiNavigation { get; set; }
    }
}
