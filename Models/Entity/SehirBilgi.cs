//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Turkiyenin81Yuzu.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class SehirBilgi
    {
        public int SehirId { get; set; }
        public string SehirAd { get; set; }
        public Nullable<int> KategoriId1 { get; set; }
        public Nullable<int> KategoriId2 { get; set; }
        public string GezilecekYer { get; set; }
        public string GezilecekYerFotograf { get; set; }
        public string Yemekler { get; set; }
        public string YemeklerFotograf { get; set; }
    
        public virtual Kategoriler Kategoriler { get; set; }
        public virtual Kategoriler Kategoriler1 { get; set; }
    }
}
