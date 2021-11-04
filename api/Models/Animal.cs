using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models
{
    [Table("animal")]
    public class Animal
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("type")]
        public string Type { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("price a month")]
        public int PriceAMonth { get; set; }
        
    }
}