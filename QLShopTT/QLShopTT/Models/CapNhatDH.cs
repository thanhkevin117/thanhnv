//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLShopTT.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CapNhatDH
    {
        public string MaCapNhat { get; set; }
        public string MaDH { get; set; }
        public string MaNV { get; set; }
        public string NoiDung { get; set; }
        public Nullable<System.DateTime> ThoiGian { get; set; }
    
        public virtual DonHang DonHang { get; set; }
        public virtual NhanVien NhanVien { get; set; }
    }
}