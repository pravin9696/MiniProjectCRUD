//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MiniProjectCRUD.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblRoleMgt
    {
        public int id { get; set; }
        public Nullable<int> loginID { get; set; }
        public string role { get; set; }
    
        public virtual tblLogin tblLogin { get; set; }
    }
}
