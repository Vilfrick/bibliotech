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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BiblioTechEntities : DbContext
    {
        public BiblioTechEntities()
            : base("name=BiblioTechEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Access> Access { get; set; }
        public virtual DbSet<Act> Act { get; set; }
        public virtual DbSet<ActStatus> ActStatus { get; set; }
        public virtual DbSet<BookGenre> BookGenre { get; set; }
        public virtual DbSet<BookList> BookList { get; set; }
        public virtual DbSet<DocumentList> DocumentList { get; set; }
        public virtual DbSet<DocumentType> DocumentType { get; set; }
        public virtual DbSet<Format> Format { get; set; }
        public virtual DbSet<Quality> Quality { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<VisitorList> VisitorList { get; set; }
    }
}
