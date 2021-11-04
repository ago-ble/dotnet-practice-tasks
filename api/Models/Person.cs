using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models
{
    [Table("person")]
    public class Person
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("animal")]
        public Animal Animal { get; set; }
    }
}