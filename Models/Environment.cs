using System.ComponentModel.DataAnnotations;

namespace PlataformaTestes.Models
{
public class TestEnvironment
{
    [Key]
    public Guid Id { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public string Tipo { get; set; }
    public Guid SystemId { get; set; }

    // Construtor padrão
    public TestEnvironment()
    {
        Nome = string.Empty;
        Descricao = string.Empty;
        Tipo = string.Empty;
    }
}

}
