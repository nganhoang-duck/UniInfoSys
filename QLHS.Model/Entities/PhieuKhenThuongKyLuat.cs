using System;
using System.Collections.Generic;

namespace QLHS.Model.Entities
{
    public partial class PhieuKhenThuongKyLuat
    {
        public int? MaSinhVien { get; set; }
        public string? KyHoc { get; set; }
        public string? NamHoc { get; set; }
        public string? KetQuaKtkl { get; set; }

        public virtual SinhVien? MaSinhVienNavigation { get; set; }
    }
}
