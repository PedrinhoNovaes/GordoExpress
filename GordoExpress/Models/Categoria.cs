using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GordoExpress.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }
        [StringLenght(100, ErrorMessage = "O Tamanho máximo é 100 caracteres")]
        [Required(ErrorMessage ="Informe o nome da categoria.")]
        [Display(Name = "Nome")]
        public string CategoriaNome { get; set; }
        public string Descricao { get; set; }

        public List<Bebida> Bebidas { get; set; }
    }
}
