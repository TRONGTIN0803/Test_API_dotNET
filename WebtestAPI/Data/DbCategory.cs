using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebtestAPI.Data
{
    [Table("Category")]
    public class DbCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCategory { get; set; }

        [Required]
        [MaxLength(100)]
        public string NameCategory { get; set; }

        public virtual List<DbProduct> Listproduct { get; set; }
    }
}
