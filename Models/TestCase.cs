using System.ComponentModel.DataAnnotations;

namespace PlataformaTestes.Models
{
    public class TestCase
    {
        [Key]
        public Guid Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Tipo { get; set; }
        public Guid SystemId { get; set; }
        public DateTime DataCriacao { get; set; } = DateTime.UtcNow;

    // Construtor padrão
    public TestCase()
    {
        Titulo = string.Empty;
        Descricao = string.Empty;
        Tipo = string.Empty;
    }
    }
}
