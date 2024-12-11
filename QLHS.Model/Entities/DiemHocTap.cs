using System;
using System.Collections.Generic;

namespace QLHS.Model.Entities
{
    public partial class DiemHocTap
    {
        public int? MaSinhVien { get; set; }
        public string? MaHocPhan { get; set; }
        public string? TenHocPhan { get; set; }
        public int? SoTinChi { get; set; }
        public string? KyHoc { get; set; }
        public string? NamHoc { get; set; }
        public double? DiemThanhPhan { get; set; }
        public double? DiemThi { get; set; }
        public double? TbchocPhan { get; set; }

        public virtual SinhVien? MaSinhVienNavigation { get; set; }
    }
}
