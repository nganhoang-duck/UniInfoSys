using System;
using System.Collections.Generic;

namespace QLHS.Model.Entities
{
    public partial class TieuChiRenLuyen
    {
        public int MaTieuChi { get; set; }
        public string? TenTieuChi { get; set; }
        public double? DiemTieuChi { get; set; }
        public string? NoiDungTieuChi { get; set; }
    }
}
