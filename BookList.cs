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
    
    public partial class BookList
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BookList()
        {
            this.Act = new HashSet<Act>();
        }
    
        public int id { get; set; }
        public string bookName { get; set; }
        public Nullable<int> amountPages { get; set; }
        public Nullable<int> format_id { get; set; }
        public string publisher { get; set; }
        public Nullable<int> quality_id { get; set; }
        public string author { get; set; }
        public Nullable<System.DateTime> publicationDate { get; set; }
        public Nullable<int> bookGenre_id { get; set; }
        public string note { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Act> Act { get; set; }
        public virtual BookGenre BookGenre { get; set; }
        public virtual Format Format { get; set; }
        public virtual Quality Quality { get; set; }
    }
}
