namespace PhoneBook.DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Phonebook")]
    public partial class Phonebook
    {
        public int Id { get; set; }

        public string Phone { get; set; }

        public string Name { get; set; }
    }
}
