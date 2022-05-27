namespace GordoExpress.Models
{
    public class Bebida
    {
        public int BebidaId { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public string ImagemUrl { get; set; }
        public string ImagemThumbnailUrl { get; set; }
        public bool IsBebidaPreferido { get; set; }
        public bool EmEstoque { get; set; }

        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
