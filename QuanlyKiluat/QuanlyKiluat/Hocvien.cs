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
    
    public partial class Hocvien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Hocvien()
        {
            this.HocVien_Phanloaikiluat = new HashSet<HocVien_Phanloaikiluat>();
            this.Hocvien_Phanloairenluyen = new HashSet<Hocvien_Phanloairenluyen>();
        }
    
        public string MaHV { get; set; }
        public string TenHV { get; set; }
        public string GioiTinh { get; set; }
        public string Chucvu { get; set; }
        public string Capbac { get; set; }
        public string Malop { get; set; }
    
        public virtual Lop Lop { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HocVien_Phanloaikiluat> HocVien_Phanloaikiluat { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Hocvien_Phanloairenluyen> Hocvien_Phanloairenluyen { get; set; }
    }
}