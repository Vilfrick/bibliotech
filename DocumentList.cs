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
    
    public partial class DocumentList
    {
        public int id { get; set; }
        public string documentName { get; set; }
        public Nullable<int> documentType_id { get; set; }
        public string note { get; set; }
    
        public virtual DocumentType DocumentType { get; set; }
    }
}