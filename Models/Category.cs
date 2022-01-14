using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyBookWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        
        [DisplayName("Display Order")]
        [Range(1,100,ErrorMessage ="O número da Ordem de Exibição só pode ser entre 1 e 100!")]
        public int DisplayOrder { get; set; }
        
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
