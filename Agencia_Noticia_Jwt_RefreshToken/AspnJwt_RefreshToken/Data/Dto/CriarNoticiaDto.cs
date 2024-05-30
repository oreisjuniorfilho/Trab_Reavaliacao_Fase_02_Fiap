using System.ComponentModel.DataAnnotations;

namespace MvcBlogNoticias.Api.Data.Dto
{
    public class CriarNoticiaDto
    {          
        public string? Genero { get; set; }
        public DateTime Lancamento { get; set; }        
        public decimal Preco { get; set; }

        [Required(ErrorMessage = "O campo de Titulo é obrigatório")]
        public string? Titulo { get; set; }
        public string? Classificacao { get; set; }
    }
}
