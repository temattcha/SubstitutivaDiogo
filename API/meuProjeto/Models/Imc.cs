namespace API.Models;
public class Imc
{
    public int? ImcId { get; set; }
    public double? ImcValor { get; set; }
    public double PesoEmKg { get; set; }
    public double AlturaEmMetros { get; set; }
    public string? Classificacao { get; set; }
    public DateTime? CriadoEm { get; set; } = DateTime.Now;
    public Aluno? Aluno { get; set; }
    public int AlunoId { get; set; }
}
