using System.ComponentModel.DataAnnotations;

namespace UdemyEFCORE.Data.Entities
{
    public class Customer
    {
        [Key]//primary key tanımlama
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

    }
}
