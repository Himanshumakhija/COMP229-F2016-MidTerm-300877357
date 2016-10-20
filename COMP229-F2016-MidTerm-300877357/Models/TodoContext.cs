namespace COMP229_F2016_MidTerm_300877357.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using COMP229_F2016_MidTerm_300877357.Models;

    public partial class TodoContext : DbContext
    {
        public TodoContext()
            : base("name=TodoContext")
        {
        }

        public virtual DbSet<Todo> Todos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
