//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCBookstore.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class VIETSACH
    {
        public int MaTG { get; set; }
        public int MaSach { get; set; }
        public string Vaitro { get; set; }
        public string Vitri { get; set; }
    
        public virtual SACH SACH { get; set; }
        public virtual TACGIA TACGIA { get; set; }
    }
}
