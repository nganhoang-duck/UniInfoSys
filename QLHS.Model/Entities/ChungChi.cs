using System;
using System.Collections.Generic;

namespace QLHS.Model.Entities
{
    public partial class ChungChi
    {
        public int MaChungChi { get; set; }
        public string? TenChungChi { get; set; }
        public int? MaSinhVien { get; set; }
        public string? XepLoai { get; set; }

        public virtual SinhVien? MaSinhVienNavigation { get; set; }
    }
}
