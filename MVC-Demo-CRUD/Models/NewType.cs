//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC_Demo_CRUD.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class NewType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NewType()
        {
            this.Newsinfo = new HashSet<Newsinfo>();
        }
    
        public int typeid { get; set; }
        public string typeName { get; set; }
        public Nullable<bool> typeIsDel { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Newsinfo> Newsinfo { get; set; }
    }
}
