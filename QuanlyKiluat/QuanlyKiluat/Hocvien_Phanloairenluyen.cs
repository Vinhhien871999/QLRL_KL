//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanlyKiluat
{
    using System;
    using System.Collections.Generic;
    
    public partial class Hocvien_Phanloairenluyen
    {
        public string Mahv_plrl { get; set; }
        public System.DateTime Thoigian { get; set; }
        public string MaHV { get; set; }
        public string MaPLRL { get; set; }
        public string MaGS { get; set; }
        public Nullable<double> Boi { get; set; }
        public Nullable<double> Chaydai { get; set; }
        public Nullable<double> Chayngan { get; set; }
        public Nullable<double> nhayxa { get; set; }
        public Nullable<int> xa { get; set; }
    
        public virtual giamsat giamsat { get; set; }
        public virtual Hocvien Hocvien { get; set; }
        public virtual Phanloairenluyen Phanloairenluyen { get; set; }
    }
}