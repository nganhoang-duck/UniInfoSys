using System;
using System.Collections.Generic;

namespace QLHS.Model.Entities
{
    public partial class ThongTinHocTap
    {
        public int? MaSinhVien { get; set; }
        public string? HeDaoTao { get; set; }
        public string? ChuyenNganh { get; set; }
        public string? KhoaHoc { get; set; }
        public string? KhoaTuyenSinh { get; set; }

        public virtual SinhVien? MaSinhVienNavigation { get; set; }
    }
}
