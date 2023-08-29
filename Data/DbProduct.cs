using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebtestAPI.Data
{
    [Table("Product")]
    public class DbProduct
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdProduct { get; set; }

        [Required]
        [MaxLength(100)]
        public string NameProduct { get; set; }

        [Required]
        public double Price { get; set; }
        [Required]
        public int Quantity { get; set; }

        public int CategoryID { get; set; }

        public virtual DbCategory category { get; set; }
    }
}
