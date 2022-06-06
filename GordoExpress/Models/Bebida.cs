using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GordoExpress.Models
{
    [Table("Bebidas")]
    public class Bebida
    {
        [Key]
        public int BebidaId { get; set; }
        [StringLength(80, MinimumLength = 4, ErrorMessage = "O Tamanho máximo é 80 caracteres")]
        [Required(ErrorMessage = "Informe o nome da bebida.")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Informe o preço da bebida.")]
        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1,999.99,ErrorMessage ="O Preço deve estar entre 1 e 999,99")]
        public decimal Preco { get; set; }
        public string ImagemUrl { get; set; }
        public string ImagemThumbnailUrl { get; set; }
        [Display(Name = "Preferido?")]
        public bool IsBebidaPreferido { get; set; }
        [Display(Name = "Estoque")]
        public bool EmEstoque { get; set; }

        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
        public bool IsBebidaPreferida { get; internal set; }
    }
}
