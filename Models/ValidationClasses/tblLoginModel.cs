using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiniProjectCRUD.Models.ValidationClasses
{
    public class tblLoginModel
    {
        public int id { get; set; }
        public string userID { get; set; }
        public string password { get; set; }
        public Nullable<bool> isActive { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblRoleMgt> tblRoleMgts { get; set; }
    }
}