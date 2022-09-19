using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UdemyEFCORE.Data.Entities
{
    //[Table(name:"Category",Schema ="c")] tablo adını ve şemasını değiştirme
    public class Category
    {
        //[Column("category_id")]kolon ismi değiştirme
        public int Id { get; set; }
        //[Required]
        //[MaxLength(100)]
        //[Column("category_name",TypeName ="nvarchar(100)")]
        public string Name { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }

    }
}
