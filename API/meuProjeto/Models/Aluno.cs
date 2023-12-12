namespace API.Models;
public class Aluno
{
    public int AlunoId { get; set; }
    public string? Nome { get; set; }
    public string? DataNascimento { get; set; }
    public DateTime? CriadoEm { get; set; } = DateTime.Now;
}
