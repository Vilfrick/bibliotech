//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace bibliotech
{
    using System;
    using System.Collections.Generic;
    
    public partial class Act
    {
        public int id { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public Nullable<System.DateTime> finaldate { get; set; }
        public Nullable<int> actStatus_id { get; set; }
        public Nullable<int> book_id { get; set; }
        public Nullable<int> visitor_id { get; set; }
    
        public virtual ActStatus ActStatus { get; set; }
        public virtual BookList BookList { get; set; }
        public virtual VisitorList VisitorList { get; set; }
    }
}
