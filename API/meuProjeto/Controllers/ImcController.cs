using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Data;
using API.Models;

namespace API.Controllers{
    [Route("pages/imc")]
    [ApiController]
    public class ImcController : ControllerBase
    {
        private readonly AppDataContext _context;
        public ImcController(AppDataContext context) =>
        _context = context;

        [HttpGet]
        [Route("listar")]
        public IActionResult Listar(){
            List<Imc> imcs = _context.Imcs.ToList();
            return Ok(imcs);
        }

        [HttpPost]
        [Route("cadastrar")]
        public IActionResult Cadastrar([FromBody]Imc imc){

            Aluno? aluno = _context.Alunos.Find(imc.AlunoId);

            imc.ImcValor = imc.PesoEmKg / (imc.AlturaEmMetros * imc.AlturaEmMetros);
            if(imc.ImcValor < 18.5){
                imc.Classificacao = "Magreza";
            } else if (imc.ImcValor >= 18.5 && imc.ImcValor <= 24.9){
                imc.Classificacao = "Normal";
            } else if (imc.ImcValor >= 25 && imc.ImcValor <= 29.9){
                imc.Classificacao = "Sobrepeso";
            } else if (imc.ImcValor >= 30 && imc.ImcValor <= 39.9){
                imc.Classificacao = "Obesidade";
            } else {
                imc.Classificacao = "Obesidade Grave";
            }

            imc.Aluno = aluno;

            _context.Imcs.Add(imc);
            _context.SaveChanges();

            return Created("",imc);
        }

    }
}
