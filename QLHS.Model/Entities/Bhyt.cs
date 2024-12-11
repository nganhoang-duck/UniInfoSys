using System;
using System.Collections.Generic;

namespace QLHS.Model.Entities
{
    public partial class Bhyt
    {
        public int? MaSinhVien { get; set; }
        public string? MaSoBhyt { get; set; }
        public string? NoiDangKyKhamChuaBenhBanDau { get; set; }

        public virtual SinhVien? MaSinhVienNavigation { get; set; }
    }
}
