//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace YemekSiparisProjesi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class IsletmeKullanici
    {
        public int IKNo { get; set; }
        public Nullable<int> IsletmeNo { get; set; }
        public Nullable<int> KullaniciNo { get; set; }
    
        public virtual Isletme Isletme { get; set; }
        public virtual Kullanici Kullanici { get; set; }
    }
}
