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
    
    public partial class giamsat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public giamsat()
        {
            this.Hocvien_Phanloairenluyen = new HashSet<Hocvien_Phanloairenluyen>();
        }
    
        public string Mags { get; set; }
        public string Tennguoigiamsat { get; set; }
        public string Chucvu { get; set; }
        public string Capbac { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Hocvien_Phanloairenluyen> Hocvien_Phanloairenluyen { get; set; }
    }
}