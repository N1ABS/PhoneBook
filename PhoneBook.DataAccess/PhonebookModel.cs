namespace PhoneBook.DataAccess
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PhonebookModel : DbContext
    {
        public PhonebookModel()
            : base("name=PhonebookModel")
        {
        }

        public virtual DbSet<Phonebook> Phonebooks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
