//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCBookStore.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBL_YAZARLAR
    {
        public int ID { get; set; }
        public string Yazar { get; set; }
        public Nullable<int> KitapID { get; set; }
    
        public virtual TBL_KITAPLAR TBL_KITAPLAR { get; set; }
    }
}
