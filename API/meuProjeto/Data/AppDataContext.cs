using API.Models;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;
namespace API.Data;
public class AppDataContext : DbContext
{
    public AppDataContext(DbContextOptions<AppDataContext> options):base(options)
    {}
    public DbSet<Aluno> Alunos { get; set; }
    public DbSet<Imc> Imcs { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Aluno>().HasData(
            new Aluno { AlunoId = 1, Nome = "Mateus", DataNascimento = "26/09/1997" },
            
            new Aluno { AlunoId = 2, Nome = "Vinicius", DataNascimento = "28/09/2000" }
        );
    }

}