using System.ComponentModel.DataAnnotations;

namespace PlataformaTestes.Models
{
    public class TestSystem  // Nome alterado de System para TestSystem
    {
        [Key]
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCriacao { get; set; } = DateTime.UtcNow;

    // Construtor padrão
    public TestSystem()
    {
        Nome = string.Empty;
        Descricao = string.Empty;
    }
    }
}
